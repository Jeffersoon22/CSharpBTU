using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba6
{
    class Klasi_2
    {
        private int jami = 0;
        public int Jami(Klasi_1 klasi_1)
        {
            foreach (var VARIABLE in klasi_1.massive)
            {
                if (VARIABLE % 2 == 0)
                {
                    jami += VARIABLE;
                }
            }
            return jami;
        }
    }
}
