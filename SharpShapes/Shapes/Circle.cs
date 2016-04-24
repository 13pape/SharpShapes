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

        //A=3.141516*r*r
        public double AreaCircle(int r)
        {
            double AreaCircle = Math.PI * r * r;
            return AreaCircle;
        }

        public Circle(int radius)
        {
            Radius = radius;
        }
    }
}
