using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba4
{
    class Samkutxedi
    {
        protected double a, b, c;
        public void Initialize(double x, double y, double z)
        {
            a = x;
            b = y;
            c = z;
        }
    }

    class GenSamkutxedi : Samkutxedi
    {
        double perimetri;

        public double GetArea()
        {
            double smallP = (a + b + c) / 2;
            double area = Math.Pow((smallP * (smallP - a) * (smallP - b) * (smallP - c)), 0.5);
            return area;
        }
        public double GetPerimeter()
        {
            perimetri = a + b + c;
            return perimetri;
        }
    }
}
