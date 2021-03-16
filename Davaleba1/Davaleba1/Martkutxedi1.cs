using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Davaleba1
{
    class Martkutxedi1
    {
        public int sigrdze, sigane;
        private int fartobi;

        public void Minicheba(int sig, int gani)
        {
            sigrdze = sig;
            sigane = gani;
        }
        public void Gamotana(Label label)
        {
            label.Text = "სიგრძე არის: " + sigrdze.ToString() +
                "\nსიგანე არის: " + sigane.ToString() + 
                $"\nმართკუთხედის ფართობი: {Fartobi()}";
        }

        public int Fartobi()
        {
            return sigrdze * sigane;
        }
    }
}
