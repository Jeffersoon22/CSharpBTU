using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Davaleba1
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            label8.Text = "";
            label3.Text = "მგზავრების რაოდენობა";
            label4.Text = "გაყიდული ბილეთების რაოდენობა";
            AirPlane airPlane = new AirPlane();
            int result = 0;
            bool isInt1 = int.TryParse(textBox1.Text, out result);
            bool isInt2 = int.TryParse(textBox2.Text, out result);

            if (isInt1 && isInt2)
            {
                airPlane.biletebi = int.Parse(textBox1.Text);
                airPlane.mgzavrebi = int.Parse(textBox2.Text);
                label6.Text = "მგზავრების რაოდენობაა: " + airPlane.biletebi.ToString();
                label7.Text = "ბილეთების რაოდენობაა: " + airPlane.mgzavrebi.ToString();
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            label3.Text = "უნივერსიტეტის დასახელება";
            label4.Text = "კურსის დასახელება";
            label6.Text = "";
            label7.Text = "";
            Student student = new Student();
            student.university = textBox1.Text;
            student.course = textBox2.Text;
            if (student.university != "" && student.course != "")
            {
                label6.Text = "სტუდენტის სასწვლებელია: " + student.university;
                label7.Text = "სტუდენტი არის " + student.course + " კურსზე";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            label8.Text = "";
            label3.Text = "ბილეთის ფასი";
            label4.Text = "გაყიდული ბილეთების რაოდენობა";
            label6.Text = "";
            label7.Text = "";
            float flt = 0;
            int result = 0;
            bool isfloat = float.TryParse(textBox1.Text, out flt);
            bool isInt = int.TryParse(textBox2.Text, out result);
            Train train = new Train();

            if (isfloat && isInt)
            {
                train.priceOfTicket = float.Parse(textBox1.Text);
                train.biletebi = int.Parse(textBox2.Text);
                label6.Text = "ბილეთის ფასი არის: " + train.priceOfTicket.ToString("N2");
                label7.Text = "გაყიდული ბილეთების რაოდენობაა: " + train.biletebi;
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            label8.Text = "";
            textBox3.Visible = false;
            label3.Text = "მარკუთხედის სიგრძე";
            label4.Text = "მარკუთხედის სიგანე";
            label6.Text = "";
            label7.Text = "";
            int result = 0;
            bool isInt1 = int.TryParse(textBox1.Text, out result);
            bool isInt2 = int.TryParse(textBox2.Text, out result);
            Martkutxedi martkutxedi = new Martkutxedi();
            if (isInt1 && isInt2)
            {
                martkutxedi.sigrdze = int.Parse(textBox1.Text);
                martkutxedi.sigane = int.Parse(textBox2.Text);
                label6.Text = "მართკუთხედის სიგრძე არის: " + martkutxedi.sigrdze;
                label7.Text = "მართკუთხედის სიგანე არის: " + martkutxedi.sigane;
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            label8.Text = "";
            textBox3.Visible = false;
            label3.Text = "მფლობელის დასახელება";
            label4.Text = "მწარმოებელის დასახელება";
            label6.Text = "";
            label7.Text = "";
            Car car = new Car();
            car.ownerName = textBox1.Text;
            car.factory = textBox2.Text;
            if (car.ownerName != "" && car.factory != "")
            {
                label6.Text = "მფლობელის სახელია: " + car.ownerName;
                label7.Text = "მწარმოებელი არის: " + car.factory;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            label8.Text = "";
            textBox3.Visible = false;
            label3.Text = "ბილეთის ფასი";
            label4.Text = "გაყიდული ბილეთების რაოდენობა";
            label6.Text = "";
            label7.Text = "";
            float flt = 0;
            int result = 0;
            bool isfloat = float.TryParse(textBox1.Text, out flt);
            bool isInt = int.TryParse(textBox2.Text, out result);
            Train1 train1 = new Train1();

            if (isfloat && isInt)
            {
                float price = float.Parse(textBox1.Text);
                int bilets = int.Parse(textBox2.Text);
                train1.Minicheba(price, bilets);
                train1.Gamotana(label6);
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            label8.Text = "";
            textBox3.Visible = false;
            label3.Text = "ბაკის ტევადობა";
            label4.Text = "მანძილი/1 ლიტრი";
            AirPlane1 airPlane = new AirPlane1();
            float result = 0;
            bool isfloat1 = float.TryParse(textBox1.Text, out result);
            bool isfloat2 = float.TryParse(textBox2.Text, out result);
            if (isfloat1 && isfloat2)
            {
                float baki = float.Parse(textBox1.Text);
                float mandzili = float.Parse(textBox2.Text);
                airPlane.Minicheba(baki, mandzili);
                airPlane.Gamotana(label6);
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            label3.Text = "";
            label4.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            textBox3.Visible = false;
            int[] scores = new int[] { 100, 99, 81, 95, 99, 83, 100, 10, 75, 100 };
            Student1 student = new Student1();
            float avg = student.Scores(scores);
            label6.Text = "სტუდენტის საშუალო ქულაა: " + avg.ToString();
            label7.Text = "სტუდენტის ქულებია: ";
            foreach (int x in scores)
                label7.Text += x.ToString() + "   ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            label8.Text = "";
            textBox3.Visible = false;
            Martkutxedi1 martkutxedi = new Martkutxedi1();
            label3.Text = "მარკუთხედის სიგრძე";
            label4.Text = "მარკუთხედის სიგანე";
            label6.Text = "";
            label7.Text = "";
            int result = 0;
            bool isInt1 = int.TryParse(textBox1.Text, out result);
            bool isInt2 = int.TryParse(textBox2.Text, out result);
            if (isInt1 && isInt2)
            {
                int sige = int.Parse(textBox1.Text);
                int gani = int.Parse(textBox2.Text);
                martkutxedi.Minicheba(sige, gani);
                martkutxedi.Gamotana(label6);
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            label3.Text = "სტუდენტის სახელი";
            label4.Text = "სტუდენტის გვარი";
            label8.Text = "სტუდენტის ასაკი";
            label6.Text = "";
            label7.Text = "";
            textBox3.Visible = true;
            Student2 student = new Student2();
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            int result = 0;
            bool isInt1 = int.TryParse(textBox3.Text, out result);
            if (isInt1)
            {
                int age = int.Parse(textBox3.Text);
                student.Minicheba(name, lastname, age);
                student.Gamotana(label6);
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Student3 student = new Student3();
            textBox1.Visible = true;
            textBox2.Visible = true;
            label3.Text = "სტუდენტის სახელი";
            label4.Text = "სტუდენტის გვარი";
            label8.Text = "სტუდენტის ასაკი";
            label6.Text = "";
            label7.Text = "";
            textBox3.Visible = true;
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            int result = 0;
            bool isInt1 = int.TryParse(textBox3.Text, out result);
            if (isInt1)
            {
                int age = int.Parse(textBox3.Text);
                student.CallPrivateVoid(name, lastname, age);
                student.Gamotana(label6);
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }
    }
}
