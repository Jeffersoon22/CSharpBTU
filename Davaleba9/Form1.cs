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
            Random rand_1 = new Random();
            int i;
            for (i = 1; i <= 20; i++)
                label1.Text += rand_1.Next(1,101) + "   ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int> { };
            label1.Text = "";
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
                        label1.Text = numbers.Count().ToString();
                    }
                }
            }
        }
    }
}
