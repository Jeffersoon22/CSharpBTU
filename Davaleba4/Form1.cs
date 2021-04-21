using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Davaleba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "პირველი გვერდი";
            label2.Text = "მეორე გვერდი";
            label3.Text = "მესამე გვერდი";
            if (label9.Visible || !textBox3.Visible)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                label3.Visible = true;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                textBox3.Visible = true;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
            }
            double result;
            GenSamkutxedi samkutxedi = new GenSamkutxedi();
            bool xIsDouble = double.TryParse(textBox1.Text, out result);
            bool yIsDouble = double.TryParse(textBox2.Text, out result);
            bool zIsDouble = double.TryParse(textBox3.Text, out result);
            if (xIsDouble && yIsDouble && zIsDouble)
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                double z = double.Parse(textBox3.Text);
                samkutxedi.Initialize(x, y, z);
                label5.Text = $"ფართობი: {samkutxedi.GetArea()}\n" +
                    $"პერიმეტრი: {samkutxedi.GetPerimeter()}";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "პირველი გვერდი";
            label2.Text = "მეორე გვერდი";
            if (!label2.Visible || textBox3.Visible)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                label3.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
            }
            double result;
            GenMartkutxedi martkutxedi = new GenMartkutxedi();
            bool fIsDouble = double.TryParse(textBox1.Text, out result);
            bool hIsDouble = double.TryParse(textBox2.Text, out result);
            if (fIsDouble && hIsDouble)
            {
                double f = double.Parse(textBox1.Text);
                double h = double.Parse(textBox2.Text);
                martkutxedi.Initialize(f);
                martkutxedi.InitializeHeight(h);
                label5.Text = $"ფართობი: {martkutxedi.Area()}";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "პირველი გვერდი";
            label2.Text = "მეორე გვერდი";
            label3.Text = "მესამე გვერდი";
            if (label8.Visible || !textBox3.Visible)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                label3.Visible = true;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                textBox3.Visible = true;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
            }
            double result;
            bool xIsDouble = double.TryParse(textBox1.Text, out result);
            bool yIsDouble = double.TryParse(textBox2.Text, out result);
            bool zIsDouble = double.TryParse(textBox3.Text, out result);
            if (xIsDouble && yIsDouble && zIsDouble)
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                double z = double.Parse(textBox3.Text);
                Samkutxedi1 samkutxedi = new Samkutxedi1(y,x,z);

                label5.Text = $"პერიმეტრი: {samkutxedi.GetPerimeter()}";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "პირველი გვერდი";
            if (label2.Visible || textBox2.Visible )
            {
                label2.Visible = false;
                textBox2.Visible = false;
                label3.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                textBox3.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false; 
                textBox6.Visible = false;
                textBox7.Visible = false;
            }
            double result;
            bool xIsDouble = double.TryParse(textBox1.Text, out result);
            if (xIsDouble)
            {
                double x = double.Parse(textBox1.Text);
                Kvadrati kvadrati = new Kvadrati(x);
                label5.Text = $"ფართობი: {kvadrati.GetArea()}";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "ვატი რომელსაც 1 საათში წვავს";
            label2.Text = "საათების რაოდენობა როცა ჩართული იყო";
            if (!label2.Visible || textBox3.Visible)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                label3.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
            }
            double result;
            bool fIsDouble = double.TryParse(textBox1.Text, out result);
            bool hIsDouble = double.TryParse(textBox2.Text, out result);
            if (fIsDouble && hIsDouble)
            {
                double w = double.Parse(textBox1.Text);
                double h = double.Parse(textBox2.Text);
                Memkvidre_1 memkvidre = new Memkvidre_1(w, h);
                memkvidre.GetValues(label5);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "პირველი გვერდი";
            label2.Text = "მეორე გვერდი";
            if (!label2.Visible || textBox3.Visible)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                label3.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
            }
            double result;
            bool fIsDouble = double.TryParse(textBox1.Text, out result);
            bool hIsDouble = double.TryParse(textBox2.Text, out result);
            if (fIsDouble && hIsDouble)
            {
                double f = double.Parse(textBox1.Text);
                double h = double.Parse(textBox2.Text);
                GenMartkutxedi1 martkutxedi = new GenMartkutxedi1(f,h);
                label5.Text = $"ფართობი: {martkutxedi.GetArea()}";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "სახელი";
            label2.Text = "გვარი";
            label3.Text = "ასაკი";
            label6.Text = "სტაჟი";
            label7.Text = "თანამდებობა";
            label8.Text = "განყოფილება";
            label9.Text = "საავადმყოფოს დასახელება";
            if (!label9.Visible || !textBox5.Visible)
            {
                label2.Visible = true;
                label3.Visible = true;
                label9.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
            }
            int result;
            bool ageisInt = int.TryParse(textBox3.Text, out result);
            bool experienceisInt = int.TryParse(textBox4.Text, out result);
            if (ageisInt && experienceisInt)
            {
                Doctor doctor = new Doctor(
                    textBox1.Text,
                    textBox2.Text,
                    int.Parse(textBox3.Text),
                    int.Parse(textBox4.Text),
                    textBox5.Text,
                    textBox6.Text,
                    textBox7.Text);
                doctor.GetValuesDetails(label5);
            }
        }
    }
}