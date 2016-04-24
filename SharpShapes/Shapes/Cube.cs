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

        public int GetArea(int aCube)
        {
            int AreaCube = 6 *( aCube * aCube);
            return AreaCube;
        }
    }
}
