using ObjectOriented.classes;
using System.Drawing;


namespace ObjectOriented
{
    public class Program
    {
        static void Main(string[] args)
        {

            var rectangle = new RectangleClass(9, 3);
            var width = rectangle.getWidth();
            Console.WriteLine("Width is "+width);
        }
    }
}
