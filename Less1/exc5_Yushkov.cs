using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exc5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решаем квадратные уравнения.");

            //Вводим данные уравнения
            Console.Write("Введите а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            //находим дескрименант
            double desc = Math.Pow(b,2) - (4 * a * c);

            //находим корни уравнения
            double x1 = (-(b) + Math.Sqrt(desc)) / (2 * a);
            double x2 = (-(b) - Math.Sqrt(desc)) / (2 * a);

            //выводим их
            Console.WriteLine("x1 = {0}\nx2 = {1}",x1,x2);

            Console.ReadKey();
        }
    }
}
