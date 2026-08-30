using ObjectOriented.classes;
using ObjectOriented.Objects;
using System.Drawing;


namespace ObjectOriented
{
    public class Program
    {
        static void Main(string[] args)
        {

            var rectangle = new RectangleClass(6, 0);
            var width = rectangle.getWidth();
            Console.WriteLine("Width is "+width);
            //Use object initializer 
            Person person1 = new Person("Thabang", 1993);
        }
    }
}
