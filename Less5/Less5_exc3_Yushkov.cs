using System;

namespace Something
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkersSalary hour = new HourlySalaryWorker(13);
            WorkersSalary month = new FixedSalaryWorker(20000);

            Console.WriteLine(hour.SalaryPerMonth());
            Console.WriteLine(month.SalaryPerMonth());

            Console.ReadKey();
        }
    }
    
    abstract class WorkersSalary
    {
        protected double _salary;
        protected double _salaryPerMonth;
        public abstract double SalaryPerMonth();

        public WorkersSalary(double salary)
        {
            _salary = salary;
        }
    }

    class HourlySalaryWorker : WorkersSalary
    {   
        public HourlySalaryWorker(double salary) : base(salary)
        {
            _salary = salary;
        }

        public override double SalaryPerMonth()
        {
            _salaryPerMonth = 20.8 * 8 * _salary;
            return _salaryPerMonth;
        }
    }

    class FixedSalaryWorker : WorkersSalary
    {
        public FixedSalaryWorker(double salary) : base(salary)
        {
            _salary = salary;
        }
        public override double SalaryPerMonth()
        {
            _salaryPerMonth = _salary;
            return _salaryPerMonth;
        }
    }

}