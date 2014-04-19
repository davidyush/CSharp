using System;
using System.Collections.Generic;

namespace Less6_exc2_Yushkov
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Soffy = new Student("Soffy", 15, true);
            Student Nikola = new Student("Nikola", 21, false);
            Student Daniel = new Student("Daniel", 15, false);
            Student Ester = new Student("Ester", 5, true);
            Student Hanna = new Student("Hanna",40,true);
            Student Kurt = new Student("Kurt", 100, false);

            //забиваем студентов
            Students all = new Students(Soffy, Nikola, Daniel, Ester,Hanna,Kurt);

            //выводим информацию о них и удаляем, тем кому не повезло
            all.PrintAllStudents();
            all.SearchAndDestroy();
            Console.WriteLine("After:\n");
            all.PrintAllStudents();

            Console.ReadKey();
        }
    }

    class Students
    {
        //коллекции разных типов студентов и в общем
        private HashSet<Student> _allStudents = new HashSet<Student>();
        private HashSet<Student> _examFailedStudents = new HashSet<Student>();
        private HashSet<Student> _absentStudents = new HashSet<Student>();

        public Students(params Student[] nothing)
        {
            foreach (Student studen in nothing)
            {
                //сортировка в соответвующие коллекции
                if (!studen["pass"] && studen["absent"]) { _examFailedStudents.Add(studen);  _absentStudents.Add(studen); }
                else if (!studen["pass"]) { _examFailedStudents.Add(studen); }
                else if (studen["absent"]) { _absentStudents.Add(studen); }
                else { _allStudents.Add(studen); }

                _allStudents.UnionWith(_examFailedStudents);
                _allStudents.UnionWith(_absentStudents);
            }
        }
        
        //вывод инофрмации об о всех студентах
        public bool PrintAllStudents()
        {
            foreach (Student item in _allStudents)
            {
              Console.WriteLine("Name: {0}\nSeccessed exams: {1}\nPassed half lessons: {2}\n",item.Name,item["pass"],item["absent"]);
            }
            
            return true;
        }
        //отчисление
        public bool SearchAndDestroy()
        {
            _allStudents.ExceptWith(_absentStudents);
            _allStudents.ExceptWith(_examFailedStudents);

            return true;
        }
    }

    class Student
    {
        private bool _passedExam;
        private bool _absentFromHalfLessons;
        private string _name;
       
        // конструктор принимает число уроков,
        //которые формируется в булевое значение больше или меньше
        public Student(string name,int numberOfAbsentLessons,bool passedExam)
        {
            _name = name;
            _passedExam = passedExam;

            if (numberOfAbsentLessons >= 20) { _absentFromHalfLessons = true; }
            else { _absentFromHalfLessons = false; }
        }

        public string Name
        {
            get { return _name; }
        }

        //индекстор свойств
        public bool this[string index]
        {
            get
            {
                switch (index)
                {
                    case "pass": return _passedExam;
                    case "absent": return _absentFromHalfLessons;
                    default: return false;
                }
            }
        }
    }
}