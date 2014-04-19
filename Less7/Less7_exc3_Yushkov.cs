using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace excep3
{
    class Program
    {
        static void Main(string[] args)
        {
            //попытка создания робота
            try
            {
                Robot th000 = new Robot("TH000", 6, 2);
            }
            catch (MassLessThenPossibleException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (HeightLessThenPossibleException e1)
            {
                Console.WriteLine(e1.Message);
            }

            Console.ReadKey();            
        }
    }

    class Robot
    {
        private double _mass;
        private double _height;
        private string _name;
        //конструтор робота с выбрасыванием соответсвующих иксепшенов
        public Robot(string name,double mass,double height)
        {
            _name = name;

            if (mass > 5) { _mass = mass; }
            else throw new MassLessThenPossibleException();

            if (height > 30) { _height = height; }
            else throw new HeightLessThenPossibleException();
            
        }
    }

    //иксепшен для массы
    class MassLessThenPossibleException : Exception
    {
        public MassLessThenPossibleException() { }
        public override string Message
        {
            get
            {
                return "Fatal Error, the mass of the robot is not correct";
            }
        }
    }
    //иксепшен для роста
    class HeightLessThenPossibleException : Exception
    {
        public HeightLessThenPossibleException() { }
        public override string Message
        {
            get
            {
                return "Fatal Error, the height of the robot is not correct";
            }
        }
    }
}
