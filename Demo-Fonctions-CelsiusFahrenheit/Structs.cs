using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Fonctions_CelsiusFahrenheit
{
    public struct Celsius {
        public double temperature;

        public Fahrenheit ToFahrenheit()
        {
            Fahrenheit result;
            result.temperature = temperature * 1.8 + 32;
            return result;
        }
    }
    public struct Fahrenheit { 
        public double temperature;

        public Celsius ToCelsius()
        {
            Celsius result;
            result.temperature = (temperature - 32) / 1.8;
            return result;
        }
    }
}
