using System;
using System.Text;

namespace TrySapper
{
    class Program
    {
        static int level;
        static int mines;
        static char _symbol;
        static int live = 2;
        static int Lookin4Win = 0;
        static char[,] field = new char[5, 5];
        static Random randBomb = new Random();
        static Random randBomb2 = new Random();
 
        static void Main(string[] args)
        {
            Start();
            Symbol();
            SetBombs();

            while (true)
            {
                if (live > 0)
                {
                Hit();
                CheckTheWin();
                    if (Lookin4Win > 10) break;
                }
                else
                {
                Console.WriteLine("Sorry, you're loser..next time...");
                break;
                }
            }
            Console.ReadKey();
        }

        public static void CheckTheWin()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (field[i, j] == '0')
                    {
                        Lookin4Win++;
                        if (Lookin4Win >= 10)
                        {
                            Console.WriteLine("Gratz!!");
                        }
                    }
                }
            }
        }

        public static void CheckTheBombs(int _strHit,int _colHit)//метод проверки шага 
        {
            if (field[_strHit,_colHit] == 'B')
                    {
                        Console.WriteLine("You have stepped on a bomb, we fell sorry for you");
                        live--;
                        mines--;
                        PaintField();
                    }
                    else
                    {
                        Console.WriteLine("All right, next step..");
                        field[_strHit,_colHit] = '0';
                        PaintField();
                    } 
        }

        public static void Hit()//метод выборки ячейки
        {
            Console.WriteLine("you have stepped seccess for {0} times", Lookin4Win);
            Console.WriteLine("Please Chose position of the cell");
            Console.Write("Choose number of string: ");
            int StrHit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose number of column: ");
            int ColumnHit = Convert.ToInt32(Console.ReadLine());
            CheckTheBombs(StrHit,ColumnHit);
        }

        static int RandomBomb()//возвращает случайное число до 5
        {
            int result = randBomb.Next(5);
            return result;
        }

        public static void SetBombs()//метод установки бомб
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    while (mines > 0)
                    {
                        int ran1 = RandomBomb();
                        int ran2 = RandomBomb();
                        if(field[ran1,ran2] != 'B')
                        {
                            field[ran1, ran2] = 'B';
                             mines--;
                        }
                    }  
                }
                Console.WriteLine();
            }
        }

        public static void PaintField()//выводим поле
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Symbol()//метод выбора символа
        {
            Console.WriteLine("Please Choose the symbol of field");
            _symbol = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    field[i, j] = _symbol;
                }
            }
            Console.WriteLine();
        }
        
        public static void Start()//метод для выбора уровня
        {
            Console.WriteLine("Choose the level, from 1 to 5");
            level = int.Parse(Console.ReadLine());

            switch (level)
            {
                case 1:
                    Console.WriteLine("You have chosen 1 level");
                    mines = level * 2;
                    Console.WriteLine("number of mines is {0}",mines);
                    break;
                case 2:
                    Console.WriteLine("You have chosen 2 level");
                    mines = level * 2;
                    Console.WriteLine("number of mines is {0}", mines);
                    break;
                case 3:
                    Console.WriteLine("You have chosen 3 level");
                    mines = level * 2;
                    Console.WriteLine("number of mines is {0}", mines);
                    break;
                case 4:
                    Console.WriteLine("You have chosen 4 level");
                    mines = level * 2;
                    Console.WriteLine("number of mines is {0}", mines);
                    break;
                case 5:
                    Console.WriteLine("You have chosen 5 level");
                    mines = level * 2;
                    Console.WriteLine("number of mines is {0}", mines);
                    break;
                default:
                    Console.WriteLine("Please write the correct level of the game next time.");
                    break;
            }    
        }
    }
}
