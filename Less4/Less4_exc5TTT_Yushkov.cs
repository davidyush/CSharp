using System;

namespace TicTacToe
{
    class TTTGame
    {
        private static char[,] board = new char [3,3];
        private static char _PlayerSymbol;
        private static char _EnemySymbol;
        private static char _symbolOfTheBoard = '*';
        private static Random rand = new Random();
        private bool endOfTheGame = true;

        public bool GameOn
        {
            get { return endOfTheGame; }
        }
        public char PlayerSymbol
        {
            get { return _PlayerSymbol; }
        }

        public char EnemySymbol
        {
            get { return _EnemySymbol; }
        }

        public TTTGame()//зполняет поля звездами
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = _symbolOfTheBoard;
                }
            }
        }

        public int GetRandom()// случайное число 0-3
        {
            int result = rand.Next(0, 3);
            return result;
        }

        public bool PaintTheBoard()//рисует поле
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return true;
        }

        public bool ChooseTheSymbol()//выбор Х или О
        {
            Console.WriteLine("X or O?");
            _PlayerSymbol = char.Parse(Console.ReadLine());
            Console.WriteLine("You have chosen \"{0}\" symbol",_PlayerSymbol);
            if (_PlayerSymbol == 'X')
            {
                _EnemySymbol = 'O';
            }
            else if (_PlayerSymbol == 'O')
            {
                _EnemySymbol = 'X';
            }
            else
            {
                Console.WriteLine("You can choose only \"X\" or \"O\"");
                ChooseTheSymbol();
            }
            return true;
        }

        public bool PlayerStep()//ход игрока пока не выберет свободную ячейку
        {
            while (true)
            {
            Console.WriteLine("Your step(string)? ");
            int strStep = int.Parse(Console.ReadLine());
            Console.WriteLine("Your step(column)? ");
            int colStep = int.Parse(Console.ReadLine());
            
            if ((board[strStep, colStep] != _PlayerSymbol) && (board[strStep, colStep] != _EnemySymbol))
                {
                board[strStep, colStep] = _PlayerSymbol;
                break;
                }
            else
                {
                    Console.WriteLine("Plaese choose an opened cell");
                }
            }
            return true;
        }

        public bool EnemyStep()//ход противника, пока не выберет свободную ячейку
        {
            while (true)
            {
                int es_str = GetRandom();
                int es_col = GetRandom();

                if (board[es_str, es_col] == _symbolOfTheBoard)
                {
                    board[es_str, es_col] = _EnemySymbol;
                    break;
                }
            }
            return true;
        }

        public bool CheckingAWinner(char theSymbol)//проверка комбинаций на выйгрыш, выглядит грамоздко,но лучше не сообразил
        {
            if (board[0, 0] == theSymbol && board[0, 1] == theSymbol && board[0, 2] == theSymbol)
            {
                Console.WriteLine("the symbol {0} has won", theSymbol);
                return endOfTheGame = false;
            }
            else if (board[1, 0] == theSymbol && board[1, 1] == theSymbol && board[1, 2] == theSymbol)
            {
                Console.WriteLine("the symbol {0} has won", theSymbol);
                return endOfTheGame = false;
            }
            else if (board[2, 0] == theSymbol && board[2, 1] == theSymbol && board[2, 2] == theSymbol)
            {
                Console.WriteLine("the symbol {0} has won", theSymbol);
                return endOfTheGame = false;
            }
            else if (board[0, 0] == theSymbol && board[1, 0] == theSymbol && board[2, 0] == theSymbol)
            {
                Console.WriteLine("the symbol {0} has won", theSymbol);
                return endOfTheGame = false;
            }
            else if (board[0, 1] == theSymbol && board[1, 1] == theSymbol && board[2, 1] == theSymbol)
            {
                Console.WriteLine("the symbol {0} has won", theSymbol);
                return endOfTheGame = false;
            }
            else if (board[0, 2] == theSymbol && board[1, 2] == theSymbol && board[2, 2] == theSymbol)
            {
                Console.WriteLine("the symbol {0} has won", theSymbol);
                return endOfTheGame = false;
            }
            else if (board[0, 0] == theSymbol && board[1, 1] == theSymbol && board[2, 2] == theSymbol)
            {
               Console.WriteLine("the symbol {0} has won", theSymbol);
               return endOfTheGame = false;
            }
            else if (board[0, 2] == theSymbol && board[1, 1] == theSymbol && board[2, 0] == theSymbol)
            {
                Console.WriteLine("the symbol {0} has won", theSymbol);
                return endOfTheGame = false;
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TTTGame op = new TTTGame();
            op.PaintTheBoard();
            op.ChooseTheSymbol();

            while (op.GameOn == true)
            {
                op.PlayerStep();
                op.PaintTheBoard();
                op.EnemyStep();
                Console.WriteLine();
                op.PaintTheBoard();
                op.CheckingAWinner(op.PlayerSymbol);
                op.CheckingAWinner(op.EnemySymbol);

            }
            Console.ReadKey();
        }
    }
}
