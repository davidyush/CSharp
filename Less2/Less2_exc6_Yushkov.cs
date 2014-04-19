using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Less2_exc6_Yushkov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Step(2,-3));//возводим в минусовую степень
            Console.ReadKey();
        }
        public static double Step(double x, int y)//сам метод.x - число ,y - степень
        {
            if (y > 0)
            {
                return x * Step(x, y - 1);//рекурсия, возводим в степень и с каждой рекурсией ее уменьшаем на 1
            }
            if (y == 0)//если степень 0
            {
                return 1.0;
            }
            return 1 / Step(x, -y);//если минусовая степень   
        }
    }
}
