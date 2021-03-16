using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Davaleba1
{
    class Train1
    {
        private int vagonebisRaodenoba=3, mgzavrebisRaodenobaVagonshi=20;
        public float biletisFasi;
        public int gayidulibiletebi;

        public void Minicheba(float price,int biletebi)
        {
            biletisFasi = price;
            gayidulibiletebi = biletebi;
            
        }
        public void Gamotana(Label label)
        {
            label.Text = $"ვაგონების რაოდნობაა: {vagonebisRaodenoba}\n" +
                $"მგზავრების რაოდენობა ვაგონში: {mgzavrebisRaodenobaVagonshi}\n" +
                $"ბილეთის ფასი არის: {biletisFasi} ₾ \n" +
                $"სულ გაყიდული ბილეთების რაოდენობაა: {gayidulibiletebi}\n";         
        }

        public float CalculateMoney()
        {
            return biletisFasi * gayidulibiletebi;
        }
        
    }
}
 