using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Enumeration_FeuRouge
{
    public struct TrafficLight
    {
        public TrafficLightColor currentColor;

        public void ChangeColor()
        {
            int actualColorId = (int)currentColor;
            actualColorId++;
            currentColor = (TrafficLightColor)(actualColorId%3);
        }
    }
}
