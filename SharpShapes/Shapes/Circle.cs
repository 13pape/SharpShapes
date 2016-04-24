using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
   public class Circle : Shape
    {
        public override int NumberOfSides { get { return 1; } }

        public override double calculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        //Constructor
        public Circle(int radius)
        {
            Radius = radius;
        }
    }
}
