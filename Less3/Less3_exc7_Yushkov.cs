using System;

namespace IHaveNoIdea
{
    class Program
    {
      static void Main(string[] args)
        {
            Console.WriteLine("Enter Password, minimun 8 numbers,maximum 10 numbers");
            long password = long.Parse(Console.ReadLine());
          /* Просим создать пароль от 8и до 10 цифр
           */

            while (true)//проверка корректности задаваемого пароля
            {
                if ((password < 9999999) || (password > 10000000000))
                {
                    Console.WriteLine("Your password isn't correct, please try again");
                }
                else
                {
                    break;
                }
                password = long.Parse(Console.ReadLine());
            }
            Console.WriteLine("The entered is seccess");
            Console.WriteLine("Yor password is {0}",password);

            Console.WriteLine("Please enter your password to destroy meteor");
            long userPut = long.Parse(Console.ReadLine());
            //просим ввести созданый пароль
            while (true)
            {
                if (userPut == password)
                {
                    Console.WriteLine("Success!The password is correct");
                    Console.WriteLine("Thanks Sir, You have destroyed meteor");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
                
                Console.WriteLine("If you want to hack please enter 'hack'");
                string putMe = Console.ReadLine();//подборка пароля
                if (putMe == "hack")
                {
                    DateTime start = DateTime.Now;// начало работы метода
                    start.ToString("yyyy-MM-dd_HH:mm:ss");
                    Console.WriteLine("Start at {0}", start); 

                    userPut = Hack(password);
                }
                else
                {
                    userPut = long.Parse(Console.ReadLine());
                }

                DateTime end = DateTime.Now;//конец работы метода подбора
                end.ToString("yyyy-MM-dd_HH:mm:ss");
                Console.WriteLine("End at {0}", end);
               
            }
            Console.ReadLine();
        }

        static long Hack(long num)//метод подбора пароля
        {
            long result = 0;
            while (result != num)
            {
                result += 1;
            }
            return result;
        }
    }
}
