using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exc4
{
    class Program
    {
        static void Main(string[] args)
        {
            /// здороваемся и просим
            /// указать зарплату за месяц
            
            Console.Write("Hi, please enter your salary: ");
            decimal salaryPerMonth = Convert.ToDecimal(Console.ReadLine());

            //расчеты
            decimal salaryPerYear = salaryPerMonth * 12;
            decimal salaryPerWeek = salaryPerMonth / 4;
            decimal salaryPerDay = salaryPerWeek / 7;
            decimal salaryPerHour = salaryPerDay / 8; //Учитывая 8-и часовой рабочий день
            decimal salaryPerMinute = salaryPerHour / 60;

            //аккуратно выкладываем всю информацию
            Console.WriteLine("For year you earn: {0}$\nPer month: {1}$\nPer week: {2}$\nPer day: {3}$\nPer hour: {4}$\nPer minute: {5}$",
                salaryPerYear,salaryPerMonth,salaryPerWeek,salaryPerDay,salaryPerHour,salaryPerMinute);

            Console.ReadKey();
        }
    }
}
