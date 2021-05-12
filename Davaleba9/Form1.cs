using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Davaleba9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            Random rand_1 = new Random();
            int i;
            for (i = 1; i <= 20; i++)
                label1.Text += rand_1.Next(1,101) + "   ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int> { };
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            int number = 0;
            Random rand_1 = new Random();
            int i;
            for (i = 1; i <= 50; i++)
            {
                number = rand_1.Next(1, 1001);
                numbers.Add(number);
            }
            int q = 10;
            int counter = 0;
            foreach (int z in numbers)
            {
                if (q == z)
                {
                    counter++;
                }
            }
            if (counter ==0)
            {
                label1.Text = $"50 მცდელობისას არ მოიძებნა რიცხვი რომელიც ტოლია {q}-ს";
            }
            else
            {
                label1.Text = $"50 მცდელობისას მოიძებნა {counter} რიცხვი რომელიც ტოლია {q}-სი";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int> { };
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            int number = 0;
            Random rand_1 = new Random();
            int i;
            for (i = 1; i <= 100; i++)
            {
                number = rand_1.Next(1, 101);
                numbers.Add(number);
            }
            Dictionary<int, int> numbersAndCounts = new Dictionary<int, int> { };
            int[,] sia = new int[,] { };
            numbersAndCounts = numbers.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .ToDictionary(x => x.Key, y => y.Count());
            //var query = lst.GroupBy(x => x)
            //  .Where(g => g.Count() > 1)
            //  .Select(y => new { Element = y.Key, Counter = y.Count() })
            //  .ToList();
            //foreach (var item in query)
            //{
            //    numbersAndCounts.Add(item.Element, item.Counter);
            //}
            foreach (var key in numbersAndCounts)
            {
                label1.Text += key.Key + " - " + key.Value + "\n";
            }
        }
        // მოცემული კოდი დაწერს ერთ გაშვებაზე რამდენი რიცხვის გენერირება დასჭირდა
        // რომ ლისტში კონკრეტული ერთ რიცხვი მაინც განმეორებულიყო 7ჯერ
        private void button4_Click(object sender, EventArgs e)
        {
            int minvalue = 7;
            List<int> numbers = new List<int> { };
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            int number = 0;
            Random rand_1 = new Random();
            int i;
            for (i = 1; i <= 1000; i++)
            {
                number = rand_1.Next(1, 30);
                numbers.Add(number);
                var query = numbers.GroupBy(x => x)
                  .Where(g => g.Count() > 1)
                  .Select(y => new { Element = y.Key, Counter = y.Count() })
                  .ToList();
                foreach (var item in query)
                {
                    if (item.Counter == 7)
                    {
                        label1.Text = numbers.Count().ToString() + " რიცხვის გენერირება დაგვჭირდა რომ ერთერთი კონკრეტული რიცხვის გენერირების რაოდენობა ყოფილიყო 7";
                    }
                }
            }
        }
        // მოცემული კოდი გამოიტანს ერთ გაშვებაზე რამდენი ღერის ამოღება დასჭირდა
        // რომ რომელიმე ასანთის ყუთ დაცარიელებულიყო

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            List<int> asantebi = new List<int> { 20, 20, 20, 20, 20 };
            Random random = new Random();
            bool isEmpty = false;
            int counter = 0;
            while (!isEmpty)
            {
                int randomYuti = random.Next(0, 5);
                if (asantebi[randomYuti] !=0)
                {
                    asantebi[randomYuti] -= 1;
                    counter++;
                }
                else
                {
                    label1.Text = counter + " ღერი დაგვჭირდა ამოსაღებად რომ ერთერთი ყუთი მაინც დაცარიელებულიყო";
                    isEmpty = true;
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            List<int> numbersBetween120 = new List<int> { };
            Random random = new Random();
            while (numbersBetween120.Count !=20)
            {
                int randomint = random.Next(20);
                if (!numbersBetween120.Contains(randomint))
                {
                    numbersBetween120.Add(randomint);
                }
            }
            foreach (int x in numbersBetween120)
            {
                label1.Text += $"    {x}";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            label1.Text = "ზომა: ";
            label2.Text = "";
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            List<double> numbersBetweenminAndMax = new List<double> { };
            Random random = new Random();
            bool lengthIsInt = int.TryParse(textBox1.Text, out _);
            if (lengthIsInt)
            {
                int length = int.Parse(textBox1.Text);
                while (numbersBetweenminAndMax.Count != length)
                {
                    double randomdouble = random.NextDouble();
                    if (!numbersBetweenminAndMax.Contains(randomdouble))
                    {
                        numbersBetweenminAndMax.Add(randomdouble);
                    }
                }
                foreach (double x in numbersBetweenminAndMax)
                {
                    label2.Text += $"    {x}";
                }
            }
            else
            {
                label2.Text = "შეიყვანე ციფრი";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "ზომა: ";
            label2.Text = "";
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            Random random = new Random();
            bool lengthIsInt = int.TryParse(textBox1.Text, out _);
            if (lengthIsInt)
            {
                int length = int.Parse(textBox1.Text);
                byte[] byteswithlength = new byte[length];
                random.NextBytes(byteswithlength);
                foreach (double x in byteswithlength)
                {
                    label2.Text += $"    {x}";
                }
            }
            else
            {
                label2.Text = "შეიყვანე ციფრი";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            label1.Text = "ზომა ჰორიზონალურად: ";
            label2.Text = "ზომა ვერტიკალურად: ";
            label3.Text = "";
            label4.Text = "";
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            bool hlengthIsInt = int.TryParse(textBox1.Text, out _);
            bool vlengthIsInt = int.TryParse(textBox2.Text, out _);
            if (hlengthIsInt && vlengthIsInt)
            {
                int hlengthIs = int.Parse(textBox1.Text);
                int vlengthIs = int.Parse(textBox2.Text);
                int[,] massive = new int[hlengthIs, vlengthIs];

                for (int i = 0; i < hlengthIs; i++)
                {
                    for (int x= 0; x < vlengthIs; x++)
                    {
                        massive[i, x] = random.Next(4, 24);
                    }
                }
                for (int i = 0; i < hlengthIs; i++)
                {
                    for (int x = 0; x < vlengthIs; x++)
                    {
                        label4.Text += massive[i, x] + "    ";
                    }
                    label4.Text += "\n";
                }
            }
            else
            {
                label3.Text = "შეიყვანე ციფრები";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            label1.Text = "ზომა ჰორიზონალურად: ";
            label2.Text = "ზომა ვერტიკალურად: ";
            label3.Text = "";
            label4.Text = "";
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            bool hlengthIsInt = int.TryParse(textBox1.Text, out _);
            bool vlengthIsInt = int.TryParse(textBox2.Text, out _);
            if (hlengthIsInt && vlengthIsInt)
            {
                int hlengthIs = int.Parse(textBox1.Text);
                int vlengthIs = int.Parse(textBox2.Text);
                double[,] massive = new double[hlengthIs, vlengthIs];

                for (int i = 0; i < hlengthIs; i++)
                {
                    for (int x = 0; x < vlengthIs; x++)
                    {
                        massive[i, x] = random.NextDouble();
                    }
                }
                for (int i = 0; i < hlengthIs; i++)
                {
                    for (int x = 0; x < vlengthIs; x++)
                    {
                        label4.Text += massive[i, x] + "    ";
                    }
                    label4.Text += "\n";
                }
            }
            else
            {
                label3.Text = "შეიყვანე ციფრები";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            label1.Text = "ზომა ჰორიზონალურად: ";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            bool hlengthIsInt = int.TryParse(textBox1.Text, out _);
            if (hlengthIsInt)
            {
                int hlengthIs = int.Parse(textBox1.Text);
                byte[] masivi = new byte[hlengthIs];
                sbyte[] masivi_1 = new sbyte[hlengthIs];
                random.NextBytes(masivi);

                for (int i = 0; i < masivi_1.Length; i++)
                {
                    masivi_1[i] = (sbyte)masivi[i];
                    foreach (byte x in masivi)
                        label4.Text += x.ToString() + "  ";
                    label4.Text += "\n";
                    foreach (sbyte x in masivi_1)
                        label4.Text += x.ToString() + "  ";
                    label4.Text += "\n";

                }
            }
            else
            {
                label3.Text = "შეიყვანე ციფრები";
            }
        }
    }
}
