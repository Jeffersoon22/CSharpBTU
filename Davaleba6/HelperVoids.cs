using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Davaleba6
{
    class HelperVoids
    {
        public int IsIntAndValue(TextBox textBox)
        {
            int failed;
            bool isInt = int.TryParse(textBox.Text, out failed);
            if (isInt)
            {
                int result = int.Parse(textBox.Text);
                return result;
            }
            else
            {
                return 0;
            }
        }
    }
}