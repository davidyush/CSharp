using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circle
{
    class Circle_Class
    {
        private double radius;
        private double area;
        private double length;
        private double Xcoordinate;
        private double Ycoordinate;
        //подразумевается что центр любой окружности (0,0)       
        
        public double Length
        {
            get {return  length = 2 * Math.PI * radius; }
            
        }

        public double Radius
        {
            get { return radius; }
            set
            { 
                if (value > 0)
                    value = radius;
                Console.WriteLine("You have changed the radius to {0}",radius);
            }
        }

        public double Area
        {
            get { return area = Math.PI * Math.Pow(radius, 2); }
            
        }


        public Circle_Class(double radius)
        {
            this.radius = radius;
            Console.WriteLine(" Now you have a circle with radius {0}",radius);
        }

        /*
         * x = r * cos(a)
         * y = r * sin(a)
         */

        public bool Coordinats(double x, double y, double angle)
        {
            Xcoordinate = radius * Math.Cos(x);
            Ycoordinate = radius * Math.Sin(y);
            Console.WriteLine("X is {0}, Y is {1} .", Xcoordinate,Ycoordinate);

            return true;
        }
        public bool Coor(double degrees)
        {
            Console.WriteLine("deg is {0}", degrees);
            Xcoordinate = Math.Cos(degrees) * radius;
            Console.WriteLine("cos is{0}, sin is {1}", Math.Cos(degrees), Math.Sin(degrees));
            Ycoordinate = Math.Sin(degrees) * radius;
            
            Console.WriteLine("X is {0}, Y is {1} .", Xcoordinate, Ycoordinate);

            return true;
        }
        
        public bool Resize(double newSize)
        {
            if (radius > newSize) radius = newSize;
            Console.WriteLine("Now radius is {0}.", radius);
            return true;
        }
    }
}
