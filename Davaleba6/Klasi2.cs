﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba6
{
    class Klasi2
    {
        private int[,] massivex2;
        int jami = 0;

        public Klasi2(int[,] massivex2)
        {
            this.massivex2 = massivex2;
        }
        public int Jami(Klasi2 klasi2)
        {
            foreach (var VARIABLE in klasi2.massivex2)
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
