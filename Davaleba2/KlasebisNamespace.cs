namespace Sivrce_1
{
    class Klasi_1
    {
        public int Metodi1(int[] massive)
        {
            int sum = 0;
            foreach (var number in massive)
            {
                if (number > 0)
                {
                    sum += number;
                }
            }

            return sum;
        }
    }
}

namespace Sivrce_2
{
    class Klasi_1
    {
        public int Metodi2(int[] massive)
        {
            int multiply = 1;
            foreach (var number in massive)
            {
                if (number<0)
                {
                    multiply *= number;
                }
            }
            return multiply;
        }
    }
}