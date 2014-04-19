using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer
{
    class Program
    {
        static void Main(string[] args)
        {
            // просим ввести данные
            Console.Write("Введите знак опреации: ");
            char operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите 1ый операнд: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 2ой операнд: ");
            double second = Convert.ToDouble(Console.ReadLine());

            switch (operation)//ответ соответсвенно операции
            {
                case '+':
                    Console.WriteLine("Ваш результат: " + (first + second));
                    break;
                case '-':
                    Console.WriteLine("Ваш результат: " + (first - second));
                    break;
                case '*':
                    Console.WriteLine("Ваш результат: " + (first * second));
                    break;
                case '/':
                    Console.WriteLine("Ваш результат: " + (first / second));
                    break;
                case '%':
                    Console.WriteLine("Ваш результат: " + (first % second));
                    break;
                default:
                    Console.WriteLine("Вы ввели что-то не то");
                    break;
            }
            Console.ReadKey();
        }
    }
}
