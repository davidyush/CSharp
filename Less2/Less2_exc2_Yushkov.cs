using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Less2_exc2_Yushkov
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
            Console.ReadKey();
        }

        public static void start()// начальная позиция, на опушке
        {
            Console.WriteLine("Вы находитесь на Опушке, перед вами развилка.\nУ вас есть выбор: налево или направо(l\\r)");
            char state = Convert.ToChar(Console.ReadLine());
            if(state == 'l')
            {
                Console.WriteLine("Вы попали в болото");
                Console.WriteLine("Вы проиграли");
            }
            else if (state == 'r')
            {
                yard();// если удачно то вызоваем следующий уровень
            }
            else
            {
                Console.WriteLine("Вы пошли не по дороге");
                Console.WriteLine("Вы проиграли");
            }
        }

        public static void yard()// позиция в саду, либо в дом, либо дальше
        {
            Console.WriteLine("Вы попали в садя рядом с домом, зайдем в дом или пойдем дальше?(h\\c)");
            char state = Convert.ToChar(Console.ReadLine());
            if (state == 'c')
            {
                Console.WriteLine("Вы угодили в болото");
                Console.WriteLine("Вы проиграли");
            }
            else if (state == 'h')
            {
                home();// если удачно то вызоваем следующий уровень
            }
            else
            {
                Console.WriteLine("Вы попали на неизвестную территорию и вас съели зерглинги");
                Console.WriteLine("Вы проиграли");
            }
        }
        public static void home()// позиция в доме, выбор между шкатулкой и сундуком
        {
            Console.WriteLine("Вы попали в дом, перед вами сундук и шкатулка, что откроете?(b- шкатулка\\c - сундук)");
            char state = Convert.ToChar(Console.ReadLine());
            if (state == 'b')
            {
                Console.WriteLine("Вы открыли шкатулку, там оказался жирный троль, который вас и съел");
                Console.WriteLine("Вы проиграли");
            }
            else if (state == 'c')
            {
                Console.WriteLine("Вы открыли сундук, а в нем клад!");// победа
            }
            else
            {
                Console.WriteLine("Нельзя открыть, то чего нет, в наказание вас закидали камнями");
                Console.WriteLine("Вы проиграли");
            }
        }
    }
}
