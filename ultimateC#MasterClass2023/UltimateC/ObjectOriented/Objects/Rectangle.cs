using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented.classes
{
    public class RectangleClass
    {
      private  int width;
        private int height;

        public RectangleClass(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void setWidth(int width){
        
            this.width = width;
        }
        public int getWidth()
        {
            return this.width;
        }

    }
}
