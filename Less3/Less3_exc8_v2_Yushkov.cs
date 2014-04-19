using System;
using System.Threading;

namespace _121
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;//задаем цвета консоли
            Console.ForegroundColor = ConsoleColor.Magenta;

            char[,] frame = new char [34, 25];//создаем 2мерынй массив

            for (int i = 0; i < 34; i++)//каждому char присваивается случайный символ
            {
                for (int j = 0; j < 25; j++)
                {
                    frame[i,j] = ReturCharacter();
                }
            }

            while (true)//бесконечно выводим все, замедляя
            {
                for (int i = 0; i < 34; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        Console.Write("\t " + frame[i, j]);
                        Thread.Sleep(3);
                    }
                }
            }

            Console.ReadKey();
        }
        
        public static char ReturCharacter()//метод задавания случайного символа
        {
            char result;
            result = (char)rnd.Next(65,122);
            
            return result;
        }
    }
}
