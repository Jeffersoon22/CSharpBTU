using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Davaleba2
{
    class Klasi3
    {
        private int[] massive;

        public Klasi3(int[] massive)
        {
            this.massive = massive;
        }
        public void GetMinimum(Label label)
        {
            int minumum = massive.Min();
            label.Text += minumum;
        }
    }
}
