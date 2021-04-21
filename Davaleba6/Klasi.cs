using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba6
{
    class Klasi
    {
        int[] masivi = { };
        int jami=0;

        public Klasi(int[] masivi)
        {
            this.masivi = masivi;
        }
        public int Jami(Klasi klasi)
        {
            foreach (int number in masivi)
            {
                if (number%2==0)
                {
                    jami += number;
                }
            }
            return jami;
        }
    }
}
