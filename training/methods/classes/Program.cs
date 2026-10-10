namespace Training.Methods.Classes;

  
    
public class Program
{
    public static void Main(){
    
        var p = new Person("Anele", 30);
        Console.WriteLine(p.Name);  // Anele
        Console.WriteLine(p.Age);   // 30

        var email = new EmailAddress("rakgoropo@gmail.com   ");
        Console.WriteLine(email.ToString());  // rakgoropo@gmail.com

        //Money
        var money = new Money(100.50m, "usd");
        Console.WriteLine(money);  // 100.50 USD

        var AdncedMoney = new AdvanceMoney(200.75m, "eur");
        Console.WriteLine(AdncedMoney);  // 200.75 EUR
    }


}