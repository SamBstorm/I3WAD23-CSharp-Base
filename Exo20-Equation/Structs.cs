using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_20_Equation
{
    public struct EqSecondDegree
    {
        public double A, B, C;

        public bool Resoudre(out double? x1, out double? x2)
        {
            x1 = null;
            x2 = null;

            double delta = (B*B) - (4*A*C);

            if (delta < 0) return false;
            //if (delta == 0)
            //{
            //    x1 = (-B) / (2*A) ;
            //    x2 = x1;
            //}
            //else
            //{
                x1 = (-B - Math.Sqrt(delta)) / (2 * A);
                x2 = (-B + Math.Sqrt(delta)) / (2 * A);
            //}

            return true;
        }
    }
}
