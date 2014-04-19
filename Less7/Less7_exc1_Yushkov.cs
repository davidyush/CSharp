using System;
using System.Collections.Generic;

namespace excep1
{
    //наш иксепшен со своим мессеждем
    class MyException : Exception
    {
        public MyException() { }
        public override string Message
        {
            get
            {
                return "Однофамильцы нам в не нужны. Уходите.";
            }
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                Emplyee dave = new Emplyee("Kent");
                Emplyee sema = new Emplyee("Kent");
                try
                {
                    //попытка добавить ребят
                    Emplyee.AddNewEmplyee(dave);
                    Emplyee.AddNewEmplyee(sema);
                }
                catch (MyException e)
                {
                    Console.WriteLine(e.Message);
                }
                Emplyee.PrintAllEmplyees();
                Console.ReadKey();
            }
        }

        class Emplyee
        {
            private string _lastName;
            private static List<Emplyee> _all = new List<Emplyee>();

            public Emplyee(string lastName)
            {
                _lastName = lastName;
            }

            public string LastName
            {
                get { return _lastName; }
            }
            //метод добавоения с поиском однофамильцев и выбросом иксепшена
            public static bool AddNewEmplyee(Emplyee obj)
            {
                _all.Add(obj);

                foreach (var item in _all)
                {
                    if (item._lastName == obj._lastName)
                        throw new MyException();
                }

                return true;
            }

            public static bool PrintAllEmplyees()
            {
                foreach (var item in _all)
                {
                    Console.WriteLine("Employee {0}", item._lastName);
                }

                return true;
            }
        }
    }
