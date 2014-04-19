using System;
using System.Collections.Generic;

namespace Less6_exc3_Yushkov
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Zoe = new Employee("Zoe", "CoffeеMaker");
            Employee Dave = new Employee("Dave", "PizzaMaker");
            Employee Joe = new Employee("Joe", "Cashier");

            Employees WeCanDoIt = new Employees();
            //создание рабочих,соединение
            WeCanDoIt.AddEmployee(Zoe);
            WeCanDoIt.AddEmployee(Dave);
            WeCanDoIt.AddEmployee(Joe);
           
            WeCanDoIt.PrintAllEmployees();
            WeCanDoIt.Dismiss(Joe);
            Console.WriteLine("After dismiss..");
            WeCanDoIt.PrintAllEmployees();
            Console.ReadKey();
        }
    }

    class Employee
    {
        private string name;
        private string work;

        public Employee(string name,string work)
        {
            this.name = name;
            this.work = work;
        }
        //индексатор полей работников
        public string this[string index]
        {
            get
            {
                switch (index)
                {
                    case "name": return name;
                    case "work": return work;
                    default: return String.Empty;
                }
            }
        }
    }

    class Employees
    {
        //лист работничков
        private List<Employee> _workers = new List<Employee>();
        //добавление новенького
        public bool AddEmployee(Employee worker)
        {
            _workers.Add(worker);
            return true;
        }
        //увольнение
        public bool Dismiss(Employee worker)
        {
            _workers.Remove(worker);
            return true;
        }
        //вывести все работников
        public bool PrintAllEmployees()
        {
            foreach (Employee item in _workers)
            {
                Console.WriteLine("Name: {0}\nWork: {1}\n",item["name"],item["work"]);
            }
            return true;
        }

    }
}
