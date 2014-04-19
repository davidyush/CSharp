using System;

namespace Less2_exc3_Yushkov
{
    class Program
    {
        static void Main(string[] args)
        {
            // запрос данных
            Console.Write("Введите желаемую сумму: ");
            double wanted = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сумму вклада: ");            
            double deposit = Convert.ToDouble(Console.ReadLine());

            double percent = 0.1;
            double perDay = (deposit * percent) / 365;// формула
            double time = wanted / perDay;

            Console.WriteLine(time + " дней вам потребуется.");//вывод
            Console.ReadLine();
            
        }
    }
}
