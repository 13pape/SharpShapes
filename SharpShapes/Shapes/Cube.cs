using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Cube : Shape
    {
        public override int NumberOfSides
        {
            get { return 6; }
        }
        public override double calculateArea()
        {
            return 6 * (Height * Height);
        }
        //constructor
        public Cube(int height)
        {
            Height = height;
        }
    }
}
