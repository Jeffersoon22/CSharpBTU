using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Davaleba1
{
    class Student2
    {
        String name, lastName;
        int age;
        public void Minicheba(string named,string lastname,int aged)
        {
            name = named;
            lastName = lastname;
            age = aged;
        }
        public void Gamotana(Label label)
        {
            label.Text = "სახელი : " + name +
                "\n გვარი: " + lastName +
                $"\nასაკი : {age}";
        }
    }
}
