namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>{ "a", "bbb", "cccc", "llll", "Dd" };
            //Where is used to filter
            var wordsLongThan2Words = words.Where(word => word.Length > 2);

            foreach (var word in wordsLongThan2Words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
