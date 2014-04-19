using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Less2_exc4_Yushkov
{
    class Program
    {
        static void Main(string[] args)
        {
            //запрашиваем ввести 1 из 5 городов
            Console.WriteLine("Готовы предожить вам погоду на завтра, ваш город?");
            Console.WriteLine("У вас на выбор: Лондон, Сеул, Оттава, Сиэтл и Токио");
            string city = Convert.ToString(Console.ReadLine());

            switch(city)//информации в соответвии городу на 2.06.13
            {
                case "Лондон":
                    Console.WriteLine("Температура: +18\nАтмосферное давление: 770\nВетер: 4 м\\с\nВлажность воздуха: 53");
                    break;
            
                case "Сеул":
                    Console.WriteLine("Температура: +23\nАтмосферное давление: 749\nВетер: 1 м\\с\nВлажность воздуха: 80");
                    break;
                
                case "Оттава":
                    Console.WriteLine("Температура: +22\nАтмосферное давление: 749\nВетер: 3 м\\с\nВлажность воздуха: 94");
                    break;
                
                case "Сиэтл":
                    Console.WriteLine("Температура: +15\nАтмосферное давление: 763\nВетер: 0 м\\с\nВлажность воздуха: 78");
                    break;
               
                case "Токио":
                    Console.WriteLine("Температура: +22\nАтмосферное давление: 752\nВетер: 5 м\\с\nВлажность воздуха: 71");
                    break;
                default:
                    Console.WriteLine("Такой информации у нас нет");
                    break;
            }
            Console.ReadKey();
        }
    }
}
