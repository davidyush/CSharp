using System;

namespace Less3_exc2_Yushkov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выставите 6 оценок прошедшему выступлению: ");
            double[] scores = new double[6];
            
            for (int i = 0; i < scores.Length; i++)//вводим данные
            {
                scores[i] = Convert.ToDouble(Console.ReadLine());
            }
            double minScore = FindMin(scores);//находим макс и мин
            double maxScore = FindMax(scores);

           // Console.WriteLine("min score is {0}, max score is {1}. ",minScore,maxScore); //проверка

            for (int i = 0; i < scores.Length; i++ )//присваиваем макс и мин по максимуму
            {
                if (scores[i] == minScore || scores[i] == maxScore)
                {
                    scores[i] = double.MaxValue;
                }
            }

            Console.Write("Оценки между максимальной и минимальной: ");
            foreach (double Nextitem in scores)
            {
                if (Nextitem == double.MaxValue) continue;//если максимальное значение, то не выведется

                Console.Write(" {0} ", Nextitem);
            }

            
            Array.Sort(scores);//приводим массив в порядок, удаляя ненужные ячейки
            Array.Resize(ref scores, 4);

            //Console.WriteLine();
            //foreach (double item in scores)    //проверка
            //{
            //  Console.WriteLine(item);
            //}
            
            Console.ReadLine();

        }

        static double FindMax(double[] arr)//метод нахождения максимума в массиве
        {
            double resultMax;
            resultMax = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > resultMax)
                {
                    resultMax = arr[i];
                }
            }
            return resultMax;
        }
        
        static double FindMin(double[] arr)//метод нахождения минимума в массиве
        {
            double resultMin;
            resultMin = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < resultMin)
                {
                    resultMin = arr[i];
                }
            }
            return resultMin;
        }

    }
}
