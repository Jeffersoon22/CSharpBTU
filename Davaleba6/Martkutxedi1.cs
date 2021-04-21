using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Davaleba6
{
    class Martkutxedi1
    {
        private int a, b, perimetri, fartobi;

        public Martkutxedi1(int a, int b)
        {
            this.a = a;
            this.b = b;
            perimetri = (a + b) * 2;
            fartobi = a * b;
        }
        public void Gamotana(Label label)
        {
            label.Text = $"მართკუთხედის გვერდებია: {a} და {b}" +
                         $"\nმართკუთხედის პერიმეტრია: {perimetri}" +
                         $"\nმართკუთხედის ფართობია: {fartobi}";
        }
    }
}
