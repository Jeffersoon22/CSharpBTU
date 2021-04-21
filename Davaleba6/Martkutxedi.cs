using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba6
{
    class Martkutxedi
    {
        private int a, b, area;

        public Martkutxedi(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Fartobi(Martkutxedi martkutxedi)
        {
            area = a * b;
            return area;
        }
    }
}
