using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Davaleba2
{
    class Samkutxedi
    {
        public double a,b,c;
        private double perimeter,area;

        public Samkutxedi(double x, double y, double z)
        {
            a = x;
            b = y;
            c = z;
            perimeter = a+ b + c;
            double smallP = (a + b + c) / 2;
            area =  Math.Pow((smallP*(smallP-a)*(smallP-b)*(smallP-c)),0.5);
        }

        public void GetValues(Label label)
        {
            label.Text = $"სამკუთხედის პერიმეტრია: {perimeter}" +
                $"\nსამკუთხედის ფართობია: {area}";
        }

    }
}
