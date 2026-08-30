namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>{ "a", "bbb", "cccc", "llll", "Dd" };
            //Where is used to filter and linq works with huge dataset 
            var wordsLongThan2Words = words.Where(word => word.Length > 2);

            foreach (var word in wordsLongThan2Words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("Any Example check any number is lager than 10");
            //Any method rerturns a bool
            var numbers = new[] { 5, 2, 6, 7, 9, 1, 15, 0, 7, 10 };
            bool isLargerThan10 = numbers.Any(number => number > 10);
            Console.WriteLine(isLargerThan10);

            Console.WriteLine("Any Example check if all element match the given criteria");






        }
    }
}
