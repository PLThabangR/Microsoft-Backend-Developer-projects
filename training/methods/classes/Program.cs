namespace Training.Methods.Classes;

public record Person(string Name, int Age);
//Design value objet for email address
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
        
        Value = value;
    }

  
}      
    
public class Program
{
    public static void Main()
    {
        var p = new Person("Anele", 30);
        Console.WriteLine(p.Name);  // Anele
        Console.WriteLine(p.Age);   // 30
    }
}