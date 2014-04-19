using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");// ввод 1-го числа
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: "); // ввод 2-го чиста
            double b = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("Summary is " + (a + b).ToString());// выводим сумму

            Console.ReadKey();
        }
    }
}
