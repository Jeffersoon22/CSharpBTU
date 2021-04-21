using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba2
{
    class Klasi1
    {
        private double a, b, c;
        public Klasi1(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetMultiply()
        {
            return a * b * c;
        }
    }
}
