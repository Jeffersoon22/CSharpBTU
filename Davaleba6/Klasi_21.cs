using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba6
{
    class Klasi_21
    {
        private int jami = 0;

        public int Jami(Klasi_11 klasi11)
        {
            foreach (var VARIABLE in klasi11.massivex2)
            {
                if (VARIABLE%2==0)
                {
                    jami += VARIABLE;
                }
            }

            return jami;
        }
    }
}
