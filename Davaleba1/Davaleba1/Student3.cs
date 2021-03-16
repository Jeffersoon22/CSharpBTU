using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Davaleba1
{
    class Student3
    {
        string name, lastName;
        int age;
        private void SetVariables(string nam, string last, int ag)
        {
            name = nam;
            lastName = last;
            age = ag;
        }
        public void CallPrivateVoid(string na, string la, int ag)
        {
            SetVariables(na, la, ag);
        }
        public void Gamotana(Label label)
        {
            label.Text = $"სახელი: {name}" +
                $"\nგვარი: {lastName}" +
                $"\nასაკი: {age}";
        }
    }
}
