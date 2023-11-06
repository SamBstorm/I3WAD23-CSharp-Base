using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_18_MiniJeux
{
    public struct Dice
    {
        public int min;
        public int max;

        public int Roll(int nbRoll = 1)
        {
            if(nbRoll < 1) nbRoll = 1;
            Random RNG = new Random();
            int result = 0;
            for(int i = 0; i < nbRoll; i++)
            {
                //result += RNG.Next(max+1-min)+min;
                result += RNG.Next(min, max+1);
            }
            return result;
        }
    }
}
