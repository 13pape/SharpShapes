using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Square : Shape
    {
        public override double calculateArea()
        {
            return Height*Height;
        }
        //public int calculateArea(int aSquare)
        //{
        //    int AreaSquare = aSquare*aSquare;
        //    return AreaSquare;
        //}
        public Square(int height)
        {
            Height = height;
        }
    }
}
