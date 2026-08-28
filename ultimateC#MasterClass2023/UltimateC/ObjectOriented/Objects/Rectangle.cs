using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented.classes
{
    public class RectangleClass
    {
        //We are using property to set and access the width
      private  int Width { set; get; }
        private int Height;

        public RectangleClass(int width, int height)
        {
            //Verfiy the parameters
            //if legnth le than one we return zero
            //Name of will return the name of the variable in string form
            width = VerifyParma(width, nameof(Width));
            height = VerifyParma(height, nameof(Height));
            this.Width = width;
            this.Height = height;
        }

        public void setWidth(int width){
        
            this.Width = width;
        }
        public int getWidth()
        {
            return this.Width;
        }
        //Expression methos
        public int getHeight() => this.Height;

        public int CalculateArea()=> this.Height*this.Width;

        //Method to verify
        private int VerifyParma(int length,string nameOf)
        {
            var nonzero = 1;
            if (length <= 0)
            {
                Console.WriteLine($"{nameOf},Cannot be negative");
                return nonzero;
            }

            return length;
          
            
           
        }
    }
}
