using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Davaleba1
{
    class AirPlane1
    {
        public float bakisTevadoba, mandzili1litrsisawvavit;
        public void Minicheba(float baki,float mandzili)
        {
            bakisTevadoba = baki;
            mandzili1litrsisawvavit = mandzili;
        }

        public void Gamotana(Label label)
        {
            label.Text = $"ბაკის ტევადობაა: {bakisTevadoba} კბ \n" +
                $"მანძილი რომელსაც თვითფრინავი \n" +
                $"ერთი ლიტრი სწავავით გიავლის არის: {mandzili1litrsisawvavit} მეტრი\n" +
                $"თვითმფრინავს შეუძლია იფრინოს: {CalculateDistance()} მეტრი ";
        }

        public float CalculateDistance()
        {
            return bakisTevadoba * mandzili1litrsisawvavit;
        }
    }
}
