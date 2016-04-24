using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Shape
    {
        public int Radius { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }
        public virtual int NumberOfSides { get { return 4; } }

       public virtual double calculateArea()
        {
            return Width * Height;
        }

        public virtual float calculateVolume()
        {
            return Height * Width * Depth;
        }
    }
}
