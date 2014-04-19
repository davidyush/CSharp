using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Less2_exc5_Yushkov
{
    class Program
    {
        enum TimeOfADay// переменные определяющие части дня
        {
            MORNING = 4,
            AFTERNOON = 12,
            EVENING = 18,
            NIGHT = 0
        }
        static void Main(string[] args)
        {
            DateTime moment = DateTime.Now;
            int hour = moment.Hour;// в переменной хранится настоящее время
            Console.WriteLine(moment);

            //в соответсвии с временем суток выдается приветсвие
            if ((hour >= (int)TimeOfADay.MORNING) && (hour < (int)TimeOfADay.AFTERNOON))
            {
                Console.WriteLine("Good moring!");
            }
            else if ((hour > (int)TimeOfADay.AFTERNOON) && (hour < (int)TimeOfADay.EVENING))
            {
                Console.WriteLine("Good afternnon!");
            }
            else if ((hour > (int)TimeOfADay.EVENING) && (hour < (int)TimeOfADay.NIGHT))
            {
                Console.WriteLine("Good evening!");
            }
            else if (hour <(int) TimeOfADay.MORNING)
            {
                Console.WriteLine("Good night!");
            }
            
            Console.ReadKey();    
        }
    }
}
