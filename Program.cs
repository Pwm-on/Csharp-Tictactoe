using System;
namespace Tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            int option, choice;
            char end;
            do
            {
                Console.Clear();
                Board board = new Board();
                Console.WriteLine("Player vs Player - 1");
                Console.WriteLine("Player vs Pc ----- 2");
                Console.Write("Option: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                if (choice == 1)
                {
                    do
                    {
                        board.Printboard();
                        do
                        {
                            if (board.turn % 2 == 0)
                            {
                                Console.WriteLine(" It's 'X' time");
                            }
                            else
                            {
                                Console.WriteLine(" It's 'O' time" );
                            }
                            Console.Write(" Pick a Quadrant: ");
                            option = int.Parse(Console.ReadLine());
                        } while (board.Pickingquadrant(option));
                        Console.Clear();
                    } while (board.EndingCondition());     
                }
                else
                {
                    do
                    {
                        board.Printboard();
                        do
                        {
                            Console.WriteLine(" Player's turn (X) ");
                            Console.Write(" Pick a Quadrant: ");
                            option = int.Parse(Console.ReadLine());
                        } while (board.Pickingquadrant(option));
                        if (board.EndingCondition())
                        {
                            Console.Clear();
                            board.Printboard();
                            board.ComputerPlaying();
                        }
                        else
                        {
                            break;
                        }
                    } while (board.EndingCondition());
                }
                Console.Write("Do you want to restart (Y/N)?");
                end = char.Parse(Console.ReadLine().ToUpper());
                Console.Clear();
            } while (end == 'Y');
        }
    }
}
