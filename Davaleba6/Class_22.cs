using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba6
{
    class Class_22
    {
        private int jami = 0;
        public Class_11 Metodi_1(int[,] massivex2)
        {
            foreach (var VARIABLE in massivex2)
            {
                if (VARIABLE>=15 && VARIABLE<25)
                {
                    jami += VARIABLE;
                }
            }

            Class_11 class11 = new Class_11(jami);
            return class11;
        }
    }
}
