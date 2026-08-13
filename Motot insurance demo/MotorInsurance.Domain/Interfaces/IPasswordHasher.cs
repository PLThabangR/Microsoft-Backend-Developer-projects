namespace MotorInsurance.Domain.Entities;

public interface IPasswordHasher
{
    /// <summary>
    /// Hashes the specified password.
    /// </summary>
    /// <param name="password"></param>
    /// <returns></returns>
    string HashPassword(string password);
    bool VerifyPassword(string password, string passwordHash);

}