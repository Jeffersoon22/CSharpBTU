using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Davaleba6
{
    class Kvadrati
    {
        private int a, perimetri, fartobi;

        public Kvadrati(int a)
        {
            this.a = a;
            perimetri = 4 * a;
            fartobi = a * a;
        }

        public void Gamotana(Label label)
        {
            label.Text = $"კვადრატის გვერდია: {a}" +
                         $"\nკვადრატის პერიმეტრია: {perimetri}" +
                         $"\nკვადრატის ფართობია: {fartobi}";
        }
    }
}
