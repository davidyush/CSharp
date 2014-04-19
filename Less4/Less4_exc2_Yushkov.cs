using System;

namespace Clerk
{
    class Clerk_Class
    {
        private string name;
        private string lastName;
        private int age;
        private string appointment;
        private double salary;
        
        private static double resultAverageSalary;
        private static double maxSalary;
        private static double minSalary;

        private static int numberOfWorkers = 1;
        public  static Clerk_Class[] employees = new Clerk_Class[numberOfWorkers];

        public static int Number
        {
            get {return numberOfWorkers -1; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Name
        {
            get { return name;  }
            set { name = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Appointment
        {
            get { return appointment; }
            set { appointment = value; }
        }

        public static bool AddEmployee(Clerk_Class obj)
        {
            employees[numberOfWorkers - 1] = obj;
            Array.Resize(ref employees, ++numberOfWorkers);

            return true;
        }
   
        public static double FindAverageSalary(params Clerk_Class [] arr)//метод вычисления средней зарплаты
        {
            for (int i = 0; i < arr.Length; i++)
            {
                resultAverageSalary += arr[i].salary;   
            }

            return resultAverageSalary/arr.Length;
        }

        public static double FindMax(params Clerk_Class[] arr)//метод нахождения минимальной зарплаты
        {
            maxSalary = arr[0].Salary;
            for (int i = 0; i < arr.Length; i++)
            {
                if (maxSalary < arr[i].Salary)
                {
                    maxSalary = arr[i].Salary;
                }
            }
            return maxSalary;
        }

        public static double FindMin(params Clerk_Class[] arr)//метод нахождения минимальной зарплаты
        {
            minSalary = arr[0].Salary;
            for (int i = 0; i < arr.Length; i++)
            {
                if (minSalary > arr[i].Salary)
                {
                    minSalary = arr[i].Salary;
                }
            }
            return minSalary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Clerk_Class bob = new Clerk_Class();
            Clerk_Class jhon = new Clerk_Class();
            Clerk_Class lloyd = new Clerk_Class();

            bob.Salary = 10;
            jhon.Salary = 20;
            lloyd.Salary = 40;

            Console.Write("The max salary is ");
            Console.WriteLine(Clerk_Class.FindMax(bob, jhon, lloyd));

            Console.Write("The min salary is ");
            Console.WriteLine(Clerk_Class.FindMin(bob, jhon, lloyd));

            Console.Write("The average salary is ");
            Console.WriteLine(Clerk_Class.FindAverageSalary(bob, jhon, lloyd));

            Clerk_Class.AddEmployee(bob);
            Clerk_Class.AddEmployee(jhon);
            Clerk_Class.AddEmployee(lloyd);
            Console.WriteLine(Clerk_Class.Number);

            Console.ReadKey();
        }
    }
}
