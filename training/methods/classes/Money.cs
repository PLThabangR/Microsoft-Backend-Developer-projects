namespace Training.Methods.Classes;

public record Money
{
    public Money(decimal amount, string currency)
    {
        if (amount < 0)
            throw new ArgumentException("Amount cannot be negative.", nameof(amount));

        if (string.IsNullOrWhiteSpace(currency))
            throw new ArgumentException("Currency cannot be empty.", nameof(currency));

        Amount = amount;
        Currency = currency.Trim().ToUpper();
    }

    public decimal Amount { get; }
    public string Currency { get; }

    // Override ToString() for better readability
    public override string ToString() => $"{Amount} {Currency}";

}

//Design value objet for email address
