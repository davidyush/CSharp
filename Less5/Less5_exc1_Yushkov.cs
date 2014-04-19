using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 4);
            Shape anyRndShape = null;
            if (random == 0)
            {
                anyRndShape = new Circle();
            }
            else if(random == 1)
            {
                anyRndShape = new Triangle();
            }
            else if (random == 2)
            {
                anyRndShape = new Square();
            }
            else if (random == 3)
            {
                anyRndShape = new Rectangle();
            }
            //фигура рисует саму себя
            anyRndShape.Draw(anyRndShape);

            Console.ReadKey();
        }
    }
//родительский класс для каждой фигуры
    abstract class Shape
    {
       abstract public void Form();
       abstract public void About();

       virtual public bool Draw(Shape obj)
       {
           obj.About();
           obj.Form();

           return true;
       }  
    }
    
    class Triangle : Shape
    {
        override public void About()
        {
            Console.WriteLine("A polygon with three corners or vertices and\nthree sides or edges which are line segments");
        }
        
        override public void Form()
        {
            Console.WriteLine("-----*-----");
            Console.WriteLine("----*-*----");
            Console.WriteLine("---*---*---");
            Console.WriteLine("--*-----*--");
            Console.WriteLine("-*-------*-");
            Console.WriteLine("***********");

        }
    }
    
    class Square : Shape
    {
        override public void About()
        {
            Console.WriteLine("This shape has four equal sides and\nfour equal angles (90-degree angles, or right angles)");
        }

        override public void Form()
        {
            Console.WriteLine("***********");
            Console.WriteLine("*---------*");
            Console.WriteLine("*---------*");
            Console.WriteLine("*---------*");
            Console.WriteLine("*---------*");
            Console.WriteLine("***********");

        }
    }
    
    class Circle : Shape
    {
        override public void About()
        {
            Console.WriteLine("A circle is the set of all points in a plane\nthat are a given distance from a given point, the centre.");
        }
        override public void Form()
        {
            Console.WriteLine("------***-----");
            Console.WriteLine("----******----");
            Console.WriteLine("--**------**--");
            Console.WriteLine("-**--------**-");
            Console.WriteLine("***--------***");
            Console.WriteLine("-**--------**-");
            Console.WriteLine("--**------**--");
            Console.WriteLine("----******----");
            Console.WriteLine("------***-----");

        }
    }
    
    class Rectangle : Shape
    {
        override public void About()
        {
            Console.WriteLine("A rectangle is any quadrilateral with four right angles.");
        }
        override public void Form()
        {
            Console.WriteLine("***********");
            Console.WriteLine("*---------*");
            Console.WriteLine("*---------*");
            Console.WriteLine("*---------*");
            Console.WriteLine("*---------*");
            Console.WriteLine("*---------*");
            Console.WriteLine("*---------*");
            Console.WriteLine("*---------*");
            Console.WriteLine("***********");

        }
    }
}