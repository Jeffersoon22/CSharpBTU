using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;

namespace Davaleba2
{
    class Klasi2
    {
        private int[] massive;

        public  Klasi2(int[] massive)
        {
            this.massive = massive;
        }
        public void GetFirstNegative(Label label)
        {
            int saveIndex=-1;
            int counter = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] < 0)
                {
                    saveIndex = i;
                    break;
                }
            }

            if (saveIndex >= 0)
            {
                label.Text = "უარყოფითი რიცხვია" + massive[saveIndex];
            }
            else
            {
                label.Text += " უარყოფითი რიცხვი არ მოიძებნა";
            }
        }
    }
}
