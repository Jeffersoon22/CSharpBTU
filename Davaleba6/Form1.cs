using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Davaleba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = "სამკუთხედი N1";
            label8.Text = "სამკუთხედი N2";
            label1.Text = "პირველი გვერდი";
            label2.Text = "მეორე გვერდი";
            label3.Text = "მესამე გვერდი";
            label4.Text = "პირველი გვერდი";
            label5.Text = "მეორე გვერდი";
            label6.Text = "მესამე გვერდი";
            if (!label6.Visible || !textBox6.Visible)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
            }
            int result;
            bool aIsInt = int.TryParse(textBox1.Text, out result);
            bool bIsInt = int.TryParse(textBox2.Text, out result);
            bool cIsInt = int.TryParse(textBox3.Text, out result);
            bool a2IsInt = int.TryParse(textBox4.Text, out result);
            bool b2IsInt = int.TryParse(textBox5.Text, out result);
            bool c2IsInt = int.TryParse(textBox6.Text, out result);
            if (aIsInt && bIsInt && cIsInt && a2IsInt && b2IsInt && c2IsInt)
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);
                int a2 = int.Parse(textBox4.Text);
                int b2 = int.Parse(textBox5.Text);
                int c2 = int.Parse(textBox6.Text);
                Samkutxedi samkutxedi1 = new Samkutxedi(a,b,c);
                Samkutxedi samkutxedi2 = new Samkutxedi(a2,b2,c2);
                int value1 = samkutxedi1.Perimetri(samkutxedi1);
                int value2 = samkutxedi1.Perimetri(samkutxedi2);
                int value3 = samkutxedi2.Perimetri(samkutxedi1);
                label9.Text = $"პირველი ობიექტიდან პირველი სამკუთხედის პერიმეტრი: {value1}" +
                    $"\nპირველი ობიექტიდან მეორე სამკუთხეხდის პერიმეტრი: {value2}" +
                    $"\nმეორე ობიექტიდან პირველი სამკუთედის პერიმეტრი: {value3}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "მართკუთხედი N1";
            label8.Text = "მართკუთხედი N2";
            label1.Text = "პირველი გვერდი";
            label2.Text = "მეორე გვერდი";
            label4.Text = "პირველი გვერდი";
            label5.Text = "მეორე გვერდი";
            if (label6.Visible || !textBox5.Visible)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = false;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = false;
            }
            int result;
            bool aIsInt = int.TryParse(textBox1.Text, out result);
            bool bIsInt = int.TryParse(textBox2.Text, out result);
            bool a2IsInt = int.TryParse(textBox4.Text, out result);
            bool b2IsInt = int.TryParse(textBox5.Text, out result);
            if (aIsInt && bIsInt  && a2IsInt && b2IsInt)
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int a2 = int.Parse(textBox4.Text);
                int b2 = int.Parse(textBox5.Text);
                Martkutxedi martkutxedi1 = new Martkutxedi(a,b);
                Martkutxedi martkutxedi2 = new Martkutxedi(a2,b2);
                int value1 = martkutxedi1.Fartobi(martkutxedi1);
                int value2 = martkutxedi1.Fartobi(martkutxedi2);
                int value3 = martkutxedi2.Fartobi(martkutxedi1);
                label9.Text = 
                    $"პირველი ობიექტიდან პირველი მართკუთხედის ფართობი: {value1}" +
                    $"\nპირველი ობიექტიდან მეორე მართკუთხედის ფართობი: {value2}" +
                    $"\nმეორე ობიექტიდან პირველი მართკუთხედის ფართობი: {value3}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = "კვადრატი N1";
            label8.Text = "კვადრატი N2";
            label1.Text = "გვერდი";
            label4.Text = "გვერდი";
            if (label5.Visible || !textBox4.Visible)
            {
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = true;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = true;
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
            int result;
            bool aIsInt = int.TryParse(textBox1.Text, out result);
            bool a2IsInt = int.TryParse(textBox4.Text, out result);
            if (aIsInt && a2IsInt)
            {
                int a = int.Parse(textBox1.Text);
                int a2 = int.Parse(textBox4.Text);
                Kvardarti kvardarti1 = new Kvardarti(a);
                Kvardarti kvardarti2 = new Kvardarti(a2);
                int value1 = kvardarti1.Fartobi(kvardarti1);
                int value2 = kvardarti1.Fartobi(kvardarti2);
                int value3 = kvardarti2.Fartobi(kvardarti1);
                label9.Text =
                    $"პირველი ობიექტიდან პირველი კვადრატის ფართობი: {value1}" +
                    $"\nპირველი ობიექტიდან მეორე კვადრატის ფართობი: {value2}" +
                    $"\nმეორე ობიექტიდან პირველი კვადრატის ფართობი: {value3}";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] massive1 = { 1,2,3,4,5};
            int[] massive2 = { 3,4,5,6};
            int[] massive3 = { 6,7,8,9};
            Klasi klasi1 = new Klasi(massive1);
            Klasi klasi2 = new Klasi(massive2);
            Klasi klasi3 = new Klasi(massive3);
            int value1 = klasi1.Jami(klasi1);
            int value2 = klasi1.Jami(klasi2);
            int value3 = klasi2.Jami(klasi3);
            int value4 = klasi3.Jami(klasi1);
            label9.Text =
                    $"პირველი ობიექტიდან პირველი მასივის ლუწი რიცხვების ჯამი: {value1}" +
                    $"\nპირველი ობიექტიდან მეორე მასივის ლუწი რიცხვების ჯამი: {value2}" +
                    $"\nმეორე ობიექტიდან მესამე მასივის ლუწი რიცხვების ჯამი: {value3}" +
                    $"\nმესამე ობიექტიდან პირველი მასივის ლუწი რიცხვების ჯამი: {value4}";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[,] massive1 = { { 1, 2, 3, 4, 5 }, { 4, 5, 6, 7, 8 } };
            int[,] massive2 = { { 5,3,1,3,4}, {7,1,3,4,5,}};
            int[,] massive3 = { { 8,7,2,3,4}, {7,5,2,1,8}};
            Klasi2 klasi21 = new Klasi2(massive1);
            Klasi2 klasi22 = new Klasi2(massive2);
            Klasi2 klasi23 = new Klasi2(massive3);
            label9.Text =
                $"პირველი ობიექტიდან პირველი მასივის ლუწი რიცხვების ჯამი: {klasi21.Jami(klasi21)}" +
                $"\nპირველი ობიექტიდან მეორე მასივის ლუწი რიცხვების ჯამი: {klasi21.Jami(klasi22)}" +
                $"\nმეორე ობიექტიდან მესამე მასივის ლუწი რიცხვების ჯამი: {klasi22.Jami(klasi23)}" +
                $"\nმესამე ობიექტიდან პირველი მასივის ლუწი რიცხვების ჯამი: {klasi23.Jami(klasi21)}";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] massive1 = { 1, 2, 3, 4, 5 };
            int[] massive2 = { 3, 4, 5, 6 };
            Klasi_1 klasi1 = new Klasi_1(massive1);
            Klasi_1 klasi12 = new Klasi_1(massive2);
            Klasi_2 klasi2 = new Klasi_2();
            int value1 = klasi2.Jami(klasi1);
            int value2 = klasi2.Jami(klasi12);
            label9.Text =
                $"მეორე ობიექტიდან პირველი პბიექტის მასივის ლუწი რიცხვების ჯამი: {value1}" +
                $"\nმეორე ობიექტიდან მეორე პირველი ტიპის ობიექტის მასივის ლუწი რიცხვების ჯამი: {value2}";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[,] massive1 = { { 1, 2, 3, 4, 5 }, { 4, 5, 6, 7, 8 } };
            int[,] massive2 = { { 54,234,43,21 }, {65,23,43,54} };
            Klasi_11 klasi11 = new Klasi_11(massive1);
            Klasi_11 klasi112 = new Klasi_11(massive2);
            Klasi_21 klasi21 = new Klasi_21();
            int value1 = klasi21.Jami(klasi11);
            int value2 = klasi21.Jami(klasi112);
            label9.Text =
                $"მეორე ობიექტიდან პირველი ობიექტის მასივის ლუწი რიცხვების ჯამი: {value1}" +
                $"\nმეორე ობიექტიდან მეორე პირველი ტიპის ობიექტის მასივის ლუწი რიცხვების ჯამი: {value2}";


        }

        private void button8_Click(object sender, EventArgs e)
        {

            label7.Text = "კვადრატი";
            label1.Text = "გვერდი";
            if (label5.Visible || !textBox4.Visible)
            {
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = true;
                label8.Visible = false;
                label9.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
            int result;
            bool aIsInt = int.TryParse(textBox1.Text, out result);
            if (aIsInt)
            {
                int a = int.Parse(textBox1.Text);
                Klasi_111 klasi111 = new Klasi_111();
                Kvadrati kvadrati = klasi111.Metodi_1(a);
                kvadrati.Gamotana(label9);
;            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label7.Text = "მართკუთხედი";
            label1.Text = "პირველი გვერდი";
            label2.Text = "მეორე გვერდი";
            if (label6.Visible || !textBox5.Visible)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = true;
                label8.Visible = false;
                label9.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
            int result;
            bool aIsInt = int.TryParse(textBox1.Text, out result);
            bool bIsInt = int.TryParse(textBox2.Text, out result);
            if (aIsInt && bIsInt)
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                Klasi_112 klasi = new Klasi_112();
                Martkutxedi1 martkutxedi1 = klasi.Metodi_1(a, b);
                martkutxedi1.Gamotana(label9);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int[] massive1 = { 1, 2, 3, 4, 5, 10, 11 };
            Class_2 class2 = new Class_2();
            Class_1 class1 = class2.Metodi_1(massive1);
            label9.Text = $"მასივში 10-20 შუალედში არსებული რიცხვების ჯამია: {class1.jami}";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int[,] massive1 = { { 54, 234, 43, 21 }, { 65, 23, 43, 54 } };
            Class_22 class22 = new Class_22();
            Class_11 class11 = class22.Metodi_1(massive1);
            label9.Text = $"ორგანზუმილებიან მასივში 15-25 შუალედში არსებული რიცვხების ჯამია: {class11.jami}";
        }
    }
}