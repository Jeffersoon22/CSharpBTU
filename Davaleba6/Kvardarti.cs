using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba6
{
    class Kvardarti
    {
        private int a, area;

        public Kvardarti(int a)
        {
            this.a = a;
        }
        public int Fartobi(Kvardarti kvardarti)
        {
            area = a*a*a*a;
            return area;
        }
    }
}
