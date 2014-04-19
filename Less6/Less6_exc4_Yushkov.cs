using System;
using System.Collections.Generic;

namespace exc4Gun
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun MyGun = new Gun();
            Console.WriteLine(MyGun.Ammo);
            MyGun.Fire(10);
            Console.WriteLine(MyGun.Ammo);
            MyGun.Load(5);
            Console.WriteLine(MyGun.Ammo);
            Console.ReadKey();
        }
    }

    class Gun
    {
        private Queue<int> _ammunition = new Queue<int>();

        public string Ammo
        {
            get { return string.Format("In the magazie {0} ammunition", _ammunition.Count); }
        }
        
        public Gun()
        {
            for (int i = 1; i <= 20; i++)
            {
                _ammunition.Enqueue(i);
            }
        }

        public void Fire(int times)
        {
            for (int i = 0; i < times; i++)
            {
                if (_ammunition.Count > 1)
                {
                    Console.WriteLine("PIF-PAF! Please don't shoot");
                    _ammunition.Dequeue();
                }
                else
                {
                    Console.WriteLine("There are no ammuntion");
                }    
            }
            
        }

        public void Load(int times)
        {
            for (int i = 0; i < times; i++)
			{
			    if (_ammunition.Count < 20)
                {
                    Console.WriteLine("loading..");
                    _ammunition.Enqueue(_ammunition.Count + 1);
                }
                else
                {
                    Console.WriteLine("The magazine is full");
                }          
			}
        }

    }
}

    

