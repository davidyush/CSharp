using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exc1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int a = sizeof(decimal);// узнаем размер
            Console.WriteLine("Size of decimal is " + a.ToString());//выводим

            Console.ReadKey();
        }
    }
}
