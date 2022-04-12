using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{

    class Culculating
    {
        public double Dist;
        private double Middlex; private double Middley;
        public string MiddleCulc;
        public void DiastanceCalculate(double x1, double y1, double x2, double y2)
        {
            Dist = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        public void calculateMiddle(double x1, double y1, double x2, double y2)
        {
            Middlex = (x1 + x2) / 2;
            Middley = (y1 + y2) / 2;
            MiddleCulc = "x = " + Middlex + " y =" + Middley;
        }

    }
}
