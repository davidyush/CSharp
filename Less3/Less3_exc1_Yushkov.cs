using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace Less3_exc1_Yushkov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите семь зароботных плат: ");
            double[] salary = new double[7];

            //Вводим данные зарплат
            for (int i = 0; i < salary.Length; i++)
            {
                Console.Write("{0}) ", i + 1);// по-порядку
                salary[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Средняя заработная плата составляет: " + AverageSalary(salary));

            Console.ReadKey();
        }

        static double AverageSalary(double[] arr)
        {
            double result = 0;
            foreach (double Nextitem in arr)//складываем все элементы массива
            {
                result += Nextitem;
            }
            return result / arr.Length;//возвращаем все платы деленные на их кол-во.
        }

    }
}
