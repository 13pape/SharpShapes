using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Cylinder : Shape
    {
        public override int NumberOfSides
        {
            get { return 3; }
        }

        public override double calculateArea()
        {
            double AreaCylinder = (2*Math.PI*Radius*Height)+(2*Math.PI*Radius*Height);
            return AreaCylinder;
        }
        //constructor
        public Cylinder(int radius, int height)
        {
            Radius = radius;
            Height = height;
        }
    }
}
