using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RouletteGame
{
    class RoulettGamePlay
    {
        private static double ourMoney = 1000;
        private static double moneyOfBank = 2000;
        private int[] numbers = new int[37];
        private string[] colors = { "black", "red" };
        private static int chosenNum;
        private static string chosenColor;
        private double rate;
        public  string typeOfGame = string.Empty;

        private static Random rand = new Random();

        public double Balance
        {
            get 
            {
                return ourMoney;
            }
            
        }
        public double MoneyOfBank
        {
            get { return moneyOfBank; }
            
        }

        private bool SetNumbers()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
            return true;
        }

        public bool CheckTheColor()
        {
            int fallen = (int)(rand.NextDouble() * colors.Length);
            string fallenColor = colors[fallen];
            Console.WriteLine("The color is {0}",fallenColor);
            if (chosenColor == fallenColor)
            {
                Console.WriteLine("Gratz! You are winner!");
                rate *= 2;
                ourMoney += rate;
                moneyOfBank -= rate;
            }
            else
            {
                Console.WriteLine("Sorry,your rate is going to the bank");
                moneyOfBank += rate;
            }
            return true;
        }

        public bool CheckTheNum()
        {
            int fallen = rand.Next(-1, 37);
            Console.WriteLine("The number is {0}",fallen);
            if (fallen == chosenNum)
            {
                Console.WriteLine("Gratz! You are winner!");
                rate *= 38;
                ourMoney += rate;
                moneyOfBank -= rate;
            }
            else
            {
                Console.WriteLine("Sorry,your money are going to the bank");
                moneyOfBank += rate;
            }
            return true;
        }

        public double WhatRate()
        {
            Console.WriteLine("Your rate?");
            double rated = double.Parse(Console.ReadLine());
            if (rated <= ourMoney)
            {
                rate = rated;
            }
            else
            {
                Console.WriteLine("You have not enough money");
                Console.WriteLine("Your balance is {0}", this.Balance);
                this.WhatRate();
            }
            ourMoney -= rated;
            Console.WriteLine("Your rate is {0}",rated);
            return rate;
        }

        public RoulettGamePlay()
        {
            Console.WriteLine("Hi,your rate on number or color?");
            string choose = Console.ReadLine();
            if (choose == "number")
            {
                Console.WriteLine("You have chosen number!");
                GameNumbers();
            }
            else if (choose == "color")
            {
                Console.WriteLine("You have chosen color!");
                GameColors();
            }
        }

        private int GameNumbers()
        {
            Console.WriteLine("What number?(0-36)");
            int choseNum = int.Parse(Console.ReadLine());
            if ((choseNum >= 0) && (choseNum < 37))
            {
                chosenNum = choseNum;
            }
            typeOfGame = "numbers";
            return chosenNum;
        }

        private bool GameColors()
        {
            Console.WriteLine("What color?(red/black)");
            string choosCol = Console.ReadLine();
            if ((choosCol == colors[0]) || (choosCol == colors[1]))
            {
                chosenColor = choosCol;
            }
            typeOfGame = "colors";
            return true;
        }
    }
}
namespace RouletteGame
{
    class Program
    {
        static void Main(string[] args)
        {

            RoulettGamePlay play = new RoulettGamePlay();

            while (play.Balance > 0 && play.MoneyOfBank > 0)
            {
                Console.WriteLine("Your balance is {0}", play.Balance);
                play.WhatRate();
                if (play.typeOfGame.Equals("numbers"))
                {
                    play.CheckTheNum();
                }
                else if (play.typeOfGame.Equals("colors"))
                {
                    play.CheckTheColor();
                }
            }
            Console.ReadKey();
        }
    }
}