using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba4
{
    class Martkutxedi
    {
        protected double fudze;
        public void Initialize(double fudz)
        {
            fudze = fudz;
        }
    }

    class GenMartkutxedi : Martkutxedi
    {
        private double simagle;
        public double Area()
        {
            double area = simagle * fudze;
            return area;
        }
        public void InitializeHeight(double height)
        {
            simagle = height;
        }
    }
}
