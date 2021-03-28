using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Davaleba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tevadoba = double.Parse(textBox1.Text);
            double distancia = double.Parse(textBox2.Text);
            Airplane airplane = new Airplane(tevadoba,distancia);
            airplane.GetValues(label3);
            label3.Text += $"\nდისტანცია რომელსაც სავსე ბაკით გაივლის: {airplane.Calcualte()} კმ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double result;

            bool aisDouble = double.TryParse(textBox1.Text,out result);
            bool bisDouble = double.TryParse(textBox2.Text,out result); 
            bool cisDouble = double.TryParse(textBox3.Text,out result);
            if (aisDouble && bisDouble && cisDouble)
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                Samkutxedi samkutxedi = new Samkutxedi(a, b, c);
                samkutxedi.GetValues(label3);
            }
       

        }

    }
}
