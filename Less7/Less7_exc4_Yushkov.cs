using System;
using System.Collections.Generic;
using System.Collections;

namespace someIntefaceExper
{
    class Program : IEnumerable
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    list.Add(i);
                }

                foreach (int item in list)
                {
                    list.Add(item);
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }


        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
