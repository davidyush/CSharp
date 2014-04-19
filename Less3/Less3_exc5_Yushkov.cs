using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Less3_exc5_Yushkov
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "* * * * * * * * ";//Third
            string b = " * * * * * * * * ";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(a + "\n" + b);
            }
            Console.ReadKey();
        }
    }
}
      /* Second
       * for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("* * * * * * * * ");
                Console.WriteLine(" * * * * * * * *");
            }
      */
        /*First
            Console.WriteLine("* * * * * * * * ");
            Console.WriteLine(" * * * * * * * *");
            Console.WriteLine("* * * * * * * * ");
            Console.WriteLine(" * * * * * * * *");
            Console.WriteLine("* * * * * * * * ");
            Console.WriteLine(" * * * * * * * *");
            Console.WriteLine("* * * * * * * * ");
            Console.WriteLine(" * * * * * * * *");
        */

