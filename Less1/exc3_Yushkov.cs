using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exc3
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Сначала спрашиваем всю информациию,
            * типы переменных в соответсвии с запрашиваемым
            */

            Console.WriteLine("Заполните, пожалуйста, следующие данные.");
            Console.Write("Ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Ваша фамилия: ");
            string lastName = Console.ReadLine();
            Console.Write("Ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ваш город: ");
            string city = Console.ReadLine();
            Console.Write("Ваш рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ваш вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            //  собираем всю информацию воедино и аккуратно выводим
            Console.WriteLine("Спасибо за предоставленную информацию.");
            Console.WriteLine("Вас зовут {0} {1}, вы из {2}, вам {3} лет,вы весите {4} кг, при росте {5} см.",
                lastName,name,city,age,weight,height);

            Console.ReadKey();
        }
    }
}
