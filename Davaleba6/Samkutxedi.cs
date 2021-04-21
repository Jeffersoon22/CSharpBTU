using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba6
{
    class Samkutxedi
    {
        private int a, b, c,perimetri;

        public Samkutxedi(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int Perimetri(Samkutxedi samkutxedi)
        {
            perimetri = samkutxedi.a + samkutxedi.b + samkutxedi.c;
            return perimetri;
        }
    }
}
