namespace Training.Methods.Classes;

public sealed record EmailAddress
{
    public string Value { get; }

    public EmailAddress(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Email address cannot be empty.", nameof(value));

        // Basic email format validation
        if (!value.Contains("@") || !value.Contains("."))
            throw new ArgumentException("Invalid email address format.", nameof(value));

        var trimmed = value.Trim();

        Value = trimmed;
    }

    // Override ToString() for better readability
    public override string ToString() => Value;


}