using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorOops_v2
{
    class Calculate
    {
        private static double number1;
        private static double number2;
        private static string result;

        //массив истории и его размер
        private static int sizeOfArray = 1;
        private static string[] OperationsHistory = new string[sizeOfArray];

        private Calculate() { }//чтоб не было возможности создания экземпляра.

        public static string Add(double num1, double num2)
        {
            number1 = num1; number2 = num2;
            result = String.Format("{0} + {1} = {2} ", number1, number2, number1 + number2);
            ReturnResult();
            return result;
        }

        public static string Minus(double num1, double num2)
        {
            number1 = num1; number2 = num2;
            result = String.Format("{0} - {1} = {2} ", number1, number2, number1 - number2);
            ReturnResult();
            return result;
        }

        public static string Multiply(double num1, double num2)
        {
            number1 = num1; number2 = num2;
            result = String.Format("{0} * {1} = {2} ", number1, number2, number1 * number2);
            ReturnResult();
            return result;
        }

        public static string Divide(double num1, double num2)
        {
            number1 = num1; number2 = num2;
            result = String.Format("{0} / {1} = {2} ", number1, number2, number1 / number2);
            ReturnResult();
            return result;
        }
        public static bool ReturnResult()//возвращая,сохраняем в массиве истории
        {
            SaveHistory(result);
            Console.WriteLine("Your result is {0}",result);

            return true;
        }

        private static bool SaveHistory(string operation)
        {
            OperationsHistory[sizeOfArray - 1] = operation;
            Array.Resize(ref OperationsHistory, ++sizeOfArray);//массив всегда имеет столько метста,сколько нужно

            return true;
        }

        public static bool WatchHistory()//показываем всю историю,начиная с последней операции
        {
            Array.Reverse(OperationsHistory);

            foreach (string NextItem in OperationsHistory)
            {
                Console.WriteLine(NextItem);
            }

            return true;
        }
    }
}
namespace CalculatorOops_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate.Add(10, 2);
            Calculate.Minus(10, 2);
            Calculate.Multiply(10, 2);
            Calculate.Divide(10, 2);

            Calculate.WatchHistory();
            Console.ReadKey();
        }
    }
}

