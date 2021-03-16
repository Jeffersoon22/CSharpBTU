using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba1
{
    class Student1
    {
        public float Scores(int[] scores)
        {
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            return sum / scores.Length;
        }
    }
}
