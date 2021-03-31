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
            label1.Text = "ბაკის მოცულობა";
            label2.Text = "ერთი ლიტრის საწვავით გადის";
            label3.Text = "";
            label4.Text = "";
            if (textBox3.Visible || textBox4.Visible)
            {
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            double result;
            bool isTevadobaDouble = double.TryParse(textBox1.Text, out result);
            bool isdistanciaDouble = double.TryParse(textBox2.Text, out result);
            if (isdistanciaDouble && isdistanciaDouble)
            {
                double tevadoba = double.Parse(textBox1.Text);
                double distancia = double.Parse(textBox2.Text);
                Airplane airplane = new Airplane(tevadoba, distancia);
                airplane.GetValues(label5);
                label5.Text += $"\nდისტანცია რომელსაც სავსე ბაკით გაივლის: {airplane.Calcualte()} კმ";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "პირველი გვერდი";
            label2.Text = "მეორე გვერდი";
            label3.Text = "მესამე გვერდი";
            label4.Text = "";

            if (!textBox3.Visible || textBox4.Visible)
            {
                textBox3.Visible = true;
                textBox4.Visible = false;
            }
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
                samkutxedi.GetValues(label5);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "მფლობელის გვარი";
            label2.Text = "კარების რაოდენობა";
            label3.Text = "ფირმა";
            label4.Text = "ფერი";

            if (!textBox3.Visible || !textBox4.Visible)
            {
                textBox3.Visible = true;
                textBox4.Visible = true;
            }
            int result;
            bool isCarNUmberInt = int.TryParse(textBox2.Text, out result);
            if (isCarNUmberInt)
            {
                string ownerLastName = textBox1.Text;
                int numberOfDoors = int.Parse(textBox2.Text);
                string brand = textBox3.Text;
                string color = textBox4.Text;
                Car car = new Car(color, numberOfDoors, ownerLastName, brand);
                car.GetValues(label5);
            }
            

        }

    }
}
