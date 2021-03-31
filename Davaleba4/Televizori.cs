using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Davaleba4
{
    class Televizori
    {
        protected double watPerhr;
        protected double hours;

        public Televizori(double watPerhr)
        {
            this.watPerhr = watPerhr;
        }
    }
    class Memkvidre_1 : Televizori
    {
        public Memkvidre_1(double watPerhr, double hours) : base(watPerhr)
        {
            this.hours = hours;
            
        }
        public void GetValues(Label label)
        {
            label.Text = $"ტელევიზორმა სულ დახარჯა: {watPerhr * hours} ვატი\n" +
                $"ჩართული იყო: {this.hours} საათი\n" +
                $"საათში ხარკავს: {this.watPerhr} ვატს";
        }
    }
}
