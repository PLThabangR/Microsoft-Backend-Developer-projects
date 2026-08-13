using System.Security.Cryptography;
using MotorInsurance.Domain.Entities;



namespace MotorInsurance.Infrastructure.Security;

/// <summary>
/// PBKDF2 password hashing implementation using RFC 2898
/// Same algorithm used by ASP.NET Core Identity
/// </summary>
public sealed class PasswordHasher : IPasswordHasher
{
    private const int Iterations = 10000;
    private const int SaltSize = 16;  // 128 bits
    private const int HashSize = 32;  // 256 bits
    private static readonly HashAlgorithmName Algorithm = HashAlgorithmName.SHA256;

    public string HashPassword(string password)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(password, nameof(password));

        // Generate cryptographically secure random salt
        byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);

        // Derive key using PBKDF2
        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, Algorithm);
        byte[] hash = pbkdf2.GetBytes(HashSize);

        // Combine salt + hash for storage
        byte[] combined = new byte[SaltSize + HashSize];
        Buffer.BlockCopy(salt, 0, combined, 0, SaltSize);
        Buffer.BlockCopy(hash, 0, combined, SaltSize, HashSize);

        return Convert.ToBase64String(combined);
    }


    public bool VerifyPassword(string storedHash, string password)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(storedHash, nameof(storedHash));
        ArgumentException.ThrowIfNullOrWhiteSpace(password, nameof(password));

        // Decode the stored hash
        byte[] combined = Convert.FromBase64String(storedHash);

        if (combined.Length != SaltSize + HashSize)
            return false;

        // Extract salt and stored hash
        byte[] salt = new byte[SaltSize];
        byte[] storedPasswordHash = new byte[HashSize];
        Buffer.BlockCopy(combined, 0, salt, 0, SaltSize);
        Buffer.BlockCopy(combined, SaltSize, storedPasswordHash, 0, HashSize);

        // Hash the input password with the same salt
        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, Algorithm);
        byte[] computedHash = pbkdf2.GetBytes(HashSize);

        // Constant-time comparison to prevent timing attacks
        return CryptographicOperations.FixedTimeEquals(computedHash, storedPasswordHash);
    }
}

