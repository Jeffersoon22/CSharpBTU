using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sivrce_1;
using Sivrce_2;

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
            label5.Text = "";
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
            label5.Text = "";
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
            label5.Text = "";
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

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label1.Text = "პირველი მნიშვნელობა";
            label2.Text = "მეორე მნიშვნელობა";
            label3.Text = "";
            label4.Text = "";
            if (textBox3.Visible || textBox4.Visible)
            {
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            int result;
            bool isAint = int.TryParse(textBox1.Text, out result);
            bool isBint = int.TryParse(textBox2.Text, out result);
            if (isAint && isBint)
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                Klasi klasi = new Klasi(a, b);
                
                label5.Text += $"\nამ ორი რიცვხის ჯამი არის: {klasi.GetSum()}";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label1.Text = "პირველი მნიშვნელობა";
            label2.Text = "მეორე მნიშვნელობა";
            label3.Text = "მესამე მნიშვნელობა";
            label4.Text = "";
            if (!textBox3.Visible || textBox4.Visible)
            {
                textBox3.Visible = true;
                textBox4.Visible = false;
            }
            double result;
            bool isAIDouble = double.TryParse(textBox1.Text, out result);
            bool isBDouble = double.TryParse(textBox2.Text, out result);
            bool isCDouble = double.TryParse(textBox3.Text, out result);
            if (textBox3.Text !="" && isAIDouble && isBDouble && isCDouble)
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                Klasi1 klasi1 = new Klasi1(a, b, c);
                label5.Text += $"\nამ სამი რიცვხის ნამრავლი არის: {klasi1.GetMultiply()}";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label1.Text = "პირველი მნიშვნელობა";
            label2.Text = "მეორე მნიშვნელობა";
            label3.Text = "მესამე მნიშვნელობა";
            label4.Text = "მეოთხე მნიშვნელობა";

            if (!textBox3.Visible || !textBox4.Visible)
            {
                textBox3.Visible = true;
                textBox4.Visible = true;
            }
            int result;
            bool isfirstint = int.TryParse(textBox1.Text, out result);
            bool issecondint = int.TryParse(textBox2.Text, out result);
            bool isthirdint = int.TryParse(textBox3.Text, out result);
            bool isforthint = int.TryParse(textBox4.Text, out result);
            if (isfirstint && issecondint && isthirdint && isforthint)
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);
                int d = int.Parse(textBox4.Text);
                int[] massive = { a,b,c,d };
                Klasi2 klasi = new Klasi2(massive);
                label5.Text = "მასივში პირველი უარყოფითი რიცხვია:";
                klasi.GetFirstNegative(label5);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label1.Text = "პირველი მნიშვნელობა";
            label2.Text = "მეორე მნიშვნელობა";
            label3.Text = "მესამე მნიშვნელობა";
            label4.Text = "მეოთხე მნიშვნელობა";

            if (!textBox3.Visible || !textBox4.Visible)
            {
                textBox3.Visible = true;
                textBox4.Visible = true;
            }
            int result;
            bool isfirstint = int.TryParse(textBox1.Text, out result);
            bool issecondint = int.TryParse(textBox2.Text, out result);
            bool isthirdint = int.TryParse(textBox3.Text, out result);
            bool isforthint = int.TryParse(textBox4.Text, out result);
            if (isfirstint && issecondint && isthirdint && isforthint)
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);
                int d = int.Parse(textBox4.Text);
                int[] massive = { a, b, c, d };
                Klasi3 klasi = new Klasi3(massive);
                label5.Text = "მასივში მინიმალური რიცხვია: ";
                klasi.GetMinimum(label5);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sivrce_1.Samkutxedi samkutxedi = new Sivrce_1.Samkutxedi();
            label5.Text = "";
            label1.Text = "პირველი კათეტი";
            label2.Text = "მეორე კათეტი";
            label3.Text = "";
            label4.Text = "";
            if (textBox3.Visible || textBox4.Visible)
            {
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            double result;
            bool isAIDouble = double.TryParse(textBox1.Text, out result);
            bool isBDouble = double.TryParse(textBox2.Text, out result);
            if (isAIDouble && isBDouble)
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                label5.Text += $"\nმართკუთხა სამკუთხედის ფართობია: {samkutxedi.Frartobi(a, b)}";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label5.Text = "";
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
            bool isAIDouble = double.TryParse(textBox1.Text, out result);
            bool isBDouble = double.TryParse(textBox2.Text, out result);
            bool isCDouble = double.TryParse(textBox3.Text, out result);
            if (textBox3.Text != "" && isAIDouble && isBDouble && isCDouble)
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                Sivrce_2.Samkutxedi samkutxedi = new Sivrce_2.Samkutxedi();
                label5.Text = $"სამკუთხედის პერიმეტრი არის: {samkutxedi.Preriemtri(a,b,c)}";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label1.Text = "პირველი გვერდი";
            label2.Text = "მეორე გვერდი";
            label3.Text = "";
            label4.Text = "";
            if (textBox3.Visible || textBox4.Visible)
            {
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            int result;
            bool isAint = int.TryParse(textBox1.Text, out result);
            bool isBint = int.TryParse(textBox2.Text, out result);
            if (isAint && isBint)
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                Sivrce_1.Martkutxedi martkutxedi = new Sivrce_1.Martkutxedi();
                label5.Text += $"\nამართკუთხედის ფართობი არის: {martkutxedi.Fartobi(a,b)}";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label1.Text = "პირველი გვერდი";
            label2.Text = "მეორე გვერდი";
            label3.Text = "";
            label4.Text = "";
            if (textBox3.Visible || textBox4.Visible)
            {
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            int result;
            bool isAint = int.TryParse(textBox1.Text, out result);
            bool isBint = int.TryParse(textBox2.Text, out result);
            if (isAint && isBint)
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                Sivrce_2.Martkutxedi martkutxedi = new Sivrce_2.Martkutxedi();
                label5.Text += $"\nამართკუთხედის პერიმეტრი არის: {martkutxedi.Perimetri(a,b)}";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label1.Text = "პირველი მნიშვნელობა";
            label2.Text = "მეორე მნიშვნელობა";
            label3.Text = "მესამე მნიშვნელობა";
            label4.Text = "მეოთხე მნიშვნელობა";

            if (!textBox3.Visible || !textBox4.Visible)
            {
                textBox3.Visible = true;
                textBox4.Visible = true;
            }
            int result;
            bool isfirstint = int.TryParse(textBox1.Text, out result);
            bool issecondint = int.TryParse(textBox2.Text, out result);
            bool isthirdint = int.TryParse(textBox3.Text, out result);
            bool isforthint = int.TryParse(textBox4.Text, out result);
            if (isfirstint && issecondint && isthirdint && isforthint)
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);
                int d = int.Parse(textBox4.Text);
                int[] massive = { a, b, c, d };
                Sivrce_1.Klasi_1 klasi = new Sivrce_1.Klasi_1();
                label5.Text = $"დადებითი ელემენტების ჯამია: {klasi.Metodi1(massive)}";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label1.Text = "პირველი მნიშვნელობა";
            label2.Text = "მეორე მნიშვნელობა";
            label3.Text = "მესამე მნიშვნელობა";
            label4.Text = "მეოთხე მნიშვნელობა";

            if (!textBox3.Visible || !textBox4.Visible)
            {
                textBox3.Visible = true;
                textBox4.Visible = true;
            }
            int result;
            bool isfirstint = int.TryParse(textBox1.Text, out result);
            bool issecondint = int.TryParse(textBox2.Text, out result);
            bool isthirdint = int.TryParse(textBox3.Text, out result);
            bool isforthint = int.TryParse(textBox4.Text, out result);
            if (isfirstint && issecondint && isthirdint && isforthint)
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);
                int d = int.Parse(textBox4.Text);
                int[] massive = { a, b, c, d };
                Sivrce_2.Klasi_1 klasi = new Sivrce_2.Klasi_1();
                label5.Text = $"უარყოფითი ელემენტების ნამრავლია: {klasi.Metodi2(massive)}";
            }
        }
    }
}
