using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Davaleba2
{
    class Airplane
    {
        private double bakisTevadoba,mandzili;

        public Airplane(double tevadoba, double distancia)
        {
            bakisTevadoba = tevadoba;
            mandzili = distancia;
        }


        public  void GetValues(Label label)
        {
            label.Text = $"ბაკის ტევადობაა: {bakisTevadoba} კბმ\n" +
                        $"მანძილი რომელსაც ერთი ლიტრი საწვავით გაივლის: {mandzili} კმ";
        }

        public  double Calcualte()
        {
            return mandzili * bakisTevadoba;
        }

    }   
}
