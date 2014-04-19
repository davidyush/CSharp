using System;

namespace exc3_exc3Less3_Yushkov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(1, 2, 3, 4, 5).ToString());

            Console.ReadKey();
        }

        static double Multiply(params double[] arrr)//метод возвращающей произведение чисел, здесь все просто
        {
            double result = 1;
            foreach (double Nextitem in arrr)
            {
                result *= Nextitem;
            }
            return result;
        }
    }
}
