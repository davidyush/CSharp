using System;
using System.Text;
using System.Threading;

namespace exc8
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;//задаем цвета консоли
            Console.ForegroundColor = ConsoleColor.Green;

            while(true)
            {
                Console.Write(RandomString(25));
                Thread.Sleep(30);//замедляем на 30 мс.
            }

            Console.ReadKey();
        }
        public static string RandomString(int size)//метод возвращающий случайный набор символов в виде строки
        {
            StringBuilder builder = new StringBuilder();
            
            char cha_cha;
            for (int i = 0; i < size; i++)
            {
                cha_cha = Convert.ToChar(random.Next(65,122));//берет все латинские буквы uni-code
                builder.Append(" \t " + cha_cha);//создание самой строки
            }
            return builder.ToString();
        }

    }
}
