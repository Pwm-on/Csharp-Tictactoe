using System;
using System.Threading;

namespace Tictactoe
{
    public class Board
    {
        public char[] boards = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
        public int turn = 0;
        public void Printboard()
        {
            Console.WriteLine(" | " + boards[0] + " | " + " | " + boards[1] + " | " + " | " + boards[2] + " | ");
            Console.WriteLine(" | " + boards[3] + " | " + " | " + boards[4] + " | " + " | " + boards[5] + " | ");
            Console.WriteLine(" | " + boards[6] + " | " + " | " + boards[7] + " | " + " | " + boards[8] + " | ");
        }
        public bool Pickingquadrant(int option)
        {
            if (boards[option] != 'X' && boards[option] != 'O')
            {
                switch (turn % 2)
                {
                    case 0:
                        boards[option] = 'X';
                        turn++;
                        break;

                    case 1:
                        boards[option] = 'O';
                        turn++;
                        break;
                }
            }
            else
            {
                Console.WriteLine(" Quadrant already picked");
                Thread.Sleep(2000);
                Console.Clear();
                Printboard();
                return true;
            }
            return false;
        }
        public bool HorizontalVerticalCondition()
        {
            for (int n = 0; n < 2; n++)
            {
                if ((boards[n] == boards[n + 1] && boards[n] == boards[n + 2]) ||
                    (boards[n] == boards[n + 3] && boards[n] == boards[n + 6]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool DiagonalConditional()
        {
            if ((boards[0] == boards[4]) && (boards[4] == boards[8]) ||
                (boards[2] == boards[4]) && (boards[4] == boards[6]))
            {
                return false;
            }
            return true;
        }

        public bool EndingCondition()
        {
            bool ending1 = HorizontalVerticalCondition();
            bool ending2 = DiagonalConditional();
            if (turn < 9)
            {
                if ((ending1 && ending2) == false)
                {
                    switch ((turn - 1)  % 2)
                    {
                        case 0:
                            Console.Clear();
                            Printboard();
                            Console.WriteLine(" X is the winner!");
                            return false;

                        case 1:
                            Console.Clear();
                            Printboard();
                            Console.WriteLine(" O is the winner!");
                            return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                Console.Clear();
                Printboard();
                Console.WriteLine("Draw");
                return false;
            }
            return true;
        }

        public void ComputerPlaying()
        {
            Random random = new Random();
            int index = random.Next(0,8);
            while ((boards[index] == 'X') || (boards[index] == 'O'))
            {
                index = random.Next(0, 8);
            }
            Console.WriteLine(" Computer's turn('O') ");
            Console.WriteLine(" Pick a Quadrant: ");
            boards[index] = 'O';
            turn++;
            Thread.Sleep(2000);
            Printboard();
            Console.Clear(); 
        }
    }
}
