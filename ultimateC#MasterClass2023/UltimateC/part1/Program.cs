namespace part1
{
    public class Program
    {
        static void Main(string[] args)
        {   //Class 
            //1 ArraysLearn();
            //2ListExample();
            var mixedNumbers = new int[] { 1, 3, -4, 7, 9, -5, -2, 6 };
            int nonPos;
            //We are returning two values from the method
            var onlyPositves = ReturnPositiveNumbers(mixedNumbers,out nonPos );
             Console.WriteLine("Non positve values are "+nonPos);



        }

        public static void ArraysLearn()
        {
            Console.WriteLine("Arrays");
            int[] numbers = new int[] { 1, 2, 50, 3, 4, 6, 10, 34 };
            var lastValue = numbers.Length - 1;

            Console.WriteLine(lastValue);
            //for loop
            //Nested for loop
            //sum 
            int total= 0;
            for (int i = 0; i<numbers.Length; i++)
            {
                Console.WriteLine(i);
                total += numbers[i];
                Console.WriteLine(total);
            }

            Console.WriteLine("Total "+total);

            foreach (int i in numbers) {
                Console.WriteLine(i);
            }
        }
        public static void ListExample()
        { //Initialization types
            var numbers = new List<int>();

            List<string> words = new List<string>();

            var cities = new List<string>
            {
                "Durban","Cape town","Jozi"
            };


            foreach (string i in cities) {
                Console.WriteLine(i);
            }
            Console.WriteLine(words.Count);

            numbers.Add(3);
            numbers.Add(23);
            Console.WriteLine($"Words count:{ numbers.Count}");
        }

        public static void OutKeyword()
        {
            
        }
        //Return a list of ositive numbers
        public static List<int> ReturnPositiveNumbers(int[] numbers,out int nonPositive){
            var positves = new List<int>();
            nonPositive = 0;
            foreach (int i in numbers) {

                if (i > 0)
                {
                    positves.Add(i);
                    continue; //I could ise conticue or else
                }
                
                    nonPositive++;
                

            }
            return positves;

        }
    }
}
