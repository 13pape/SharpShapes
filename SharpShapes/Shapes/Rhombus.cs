using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Rhombus
    {
        public int GetArea(int pDiagonal, int qDiagonal)
        {
            int AreaRhombus = (pDiagonal*qDiagonal)/2;
            return AreaRhombus;
        }
    }
}
