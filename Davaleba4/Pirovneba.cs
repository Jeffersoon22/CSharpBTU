using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Davaleba4
{
    class Pirovneba
    {
        protected string name, lastname;
        protected int age;

        public Pirovneba(string name, string lastname, int age)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }
        public string GetValues()
        {
            return $"სახელი: {this.name}\n" +
                $"გვარი: {this.lastname}\n" +
                $"ასაკი: {this.age}\n";
        }
    }
    class Doctor : Pirovneba
    {
        public string ganyofileba, tanamdeboba, saavadmyofo;
        public int experience;

        public Doctor(string name, string lastname, int age, int experience, string tanamdeboba, string ganyofileba, string saavadmyofo) 
            : base(name, lastname, age)
        {
            this.ganyofileba = ganyofileba;
            this.tanamdeboba = tanamdeboba;
            this.saavadmyofo = saavadmyofo;
            this.experience = experience;
        }
        public void GetValuesDetails(Label label)
        {
            label.Text = GetValues() + $"თანამდებობა: {this.tanamdeboba}" +
                $"\nსტაჟი: {this.experience}" +
                $"\nგანყოფილება: {this.ganyofileba}" +
                $"\nსაავადმყოფო: {this.saavadmyofo}";
        }
    }
}
