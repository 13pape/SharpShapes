using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Rhombus: Shape
    {
        public override double calculateArea()
        {
            return (Height * Width)/2;
        }
        //Constructor
        public Rhombus(int height, int width)
        {
            Height = height;
            Width = width;
        }
    }
}
