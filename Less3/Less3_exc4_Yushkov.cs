using System;

namespace someNew
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] some = {1,2,3,4,5,6,7 };

            foreach (int item in some)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            for (int i = 1; i < some.Length - 1; i++)
            {
                for (int j = i + 1; j < some.Length - 1; j++)
                {
                    if (some[i] < some[j]) // проверяем "элемент_слева" < "элемент_справа"?
                    {
                        //"меняем" местами меньший левый элемент на больший правый

                        int tmp = some[i]; //запоминаем "элемент_слева" ШАГ 1
                        some[i] = some[j];  //присваиваем к "элементу_слева" значение "элемента_справа" ШАГ 2
                        some[j] = tmp;     //присваиваем к "элементу_справа" запомненное ранее на шаге 1 значение "элемента_слева" ШАГ 3
                    }
                }
            }

            foreach (int item in some)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
