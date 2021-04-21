using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba6
{
    class Class_2
    {
        private int jami = 0;
        public Class_1 Metodi_1(int[] massive)
        {
            foreach (var number in massive)
            {
                if (number>=10 && number<20)
                {
                    jami += number;
                }
            }

            Class_1 class_1 = new Class_1(jami);
            return class_1;
        }
    }
}
