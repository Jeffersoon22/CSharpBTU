using System;
using System.Collections.Generic;
using System.Text;

namespace Davaleba4
{
    class MartkutxediBase
    {
        protected double fudze;

        public MartkutxediBase(double fudze)
        {
            this.fudze = fudze;
        }

        public string GetValue()
        {
            string result = $"ფუძე: {fudze}";
            return result;
        }
    }
    class GenMartkutxedi1 : MartkutxediBase
    {
        double height;

        public GenMartkutxedi1(double fudze,double height) : base(fudze)
        {
            this.height = height;
        }
        public double GetArea()
        {
            return height * fudze;
        }
    }
}
