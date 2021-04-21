using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba4
{
    class Figura
    {
        public double gverdi1;
        public Figura(double gverdi1)
        {
            this.gverdi1 = gverdi1;
        }
        public Figura()
        {
        }

    }
    class Samkutxedi1 : Figura
    {
        public double gverdi2;
        public double gverdi3;

        public Samkutxedi1(double a, double b, double c) :base(a)
        {
            gverdi2 = b;
            gverdi3 = c;
        }
        public double GetPerimeter()
        {
            return gverdi1 + gverdi2 + gverdi3;
        }
    }
    class Kvadrati : Figura
    {
        public Kvadrati(double a) : base(a)
        {   
        }
        public double GetArea()
        {
            double area = Math.Pow(gverdi1, 2);
            return area;
        }
    }

}
