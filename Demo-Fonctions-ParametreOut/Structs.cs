using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Fonctions_ParametreOut
{
    public struct Mathematique
    {
        public double CompleteDivisionResult(
            double nb1,
            double nb2,
            out double moduloResult,
            out int divisionResult)
        {
            moduloResult = nb1 % nb2;
            divisionResult = (int)(nb1 / nb2);
            return nb1 / nb2;
        }

        public double Moyenne(int[] values)
        {
            double[] valuesDouble = new double[values.Length];
            for(int i=0; i< values.Length; i++)
            {
                valuesDouble[i] = values[i];
            }
            return Moyenne(valuesDouble);
        }

        public double Moyenne(double[] values)
        {
            double somme = 0;
            foreach (double value in values)
            {
                somme += value;
            }
            return somme / values.Length;
        }
    }
}
