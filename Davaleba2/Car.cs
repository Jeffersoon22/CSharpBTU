using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba2
{
    class Car
    {
        private string color;
        private int numberdoors;
        public string ownerLastName,brand;

        public Car(string feri, int karebebi, string mflobelisgvari, string firma)
        {
            color = feri;
            numberdoors = karebebi;
            ownerLastName = mflobelisgvari;
            brand = firma;
        }

        public void GetValues()
        {
            Console.WriteLine(color +"\n"+numberdoors);
        }

    }
}
