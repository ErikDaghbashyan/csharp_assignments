using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class TicTacToe
    {
        private string player1;
        private string player2;
        private int steps;
        public char[,] Board { get; set; }
        public TicTacToe(string name1, string name2)
        {
            player1 = name1;
            player2 = name2;
        }
        public void NewBoard()
        {
            Board = new char[3, 3];
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Board[i, j] = ' ';
                }
            }
        }
        public void DisplayBoard()
        {
            Console.WriteLine(" {0} | {1} | {2} ", Board[0, 0], Board[0, 1], Board[0, 2]);
            Console.WriteLine("--- --- ---");
            Console.WriteLine(" {0} | {1} | {2} ", Board[1, 0], Board[1, 1], Board[1, 2]);
            Console.WriteLine("--- --- ---");
            Console.WriteLine(" {0} | {1} | {2} ", Board[2, 0], Board[2, 1], Board[2, 2]);
        }
        public void Play()
        {
            steps = 0;
            NewBoard();
            while (steps != 9)
            {
                Console.WriteLine(" 1 | 2 | 3 ");
                Console.WriteLine("--- --- ---");
                Console.WriteLine(" 4 | 5 | 6 ");
                Console.WriteLine("--- --- ---");
                Console.WriteLine(" 7 | 8 | 9 \n");
                Console.WriteLine($"Player 1-> X: {player1}");
                Console.WriteLine($"Player 2-> O: {player2}");
                string player = (steps % 2 == 0) ? player1 : player2;

                DisplayBoard();
                Console.WriteLine($"Your turn {player} : select 1 through 9");

                int Input;
                do
                {
                    int.TryParse(Console.ReadLine(), out Input);
                } while (!InputCheck(Input));

                char XorO = (player == player1 ? 'X' : 'O');
                Turn(Input, XorO);

                steps++;

                if (steps > 4 && CheckWinner(Input, XorO))
                {
                    Console.WriteLine($"Player {player} is the winner!");
                    break;
                }

                Console.Clear();
            }

            if (steps == 9)
            {
                Console.WriteLine("The game ended in a tie!");
            }
            DisplayBoard();
        }
        private bool InputCheck(int turn)
        {
            if (turn < 1 || turn > 9)
            {
                Console.WriteLine("Please write a number from 1 to 9");
                return false;
            }
            if (IsBusy(turn))
            {
                Console.WriteLine("Place has already marker, please select another place");
                return false;
            }
            return true;
        }
        private bool IsBusy(int turn)
        {
            int row = (turn - 1) / 3;
            int col = (turn - 1) % 3;
            if (Board[row, col] == 'X' || Board[row, col] == 'O')
            {
                return true;
            }
            return false;
        }
        private void Turn(int turn, char XorO)
        {
            int row = (turn - 1) / 3;
            int col = (turn - 1) % 3;
            Board[row, col] = XorO;
        }
        private bool CheckWinner(int turn, char XorO)
        {
            int row = (turn - 1) / 3;
            int col = (turn - 1) % 3;
            int i = 0;
            while (i < 3 && Board[row, i] == XorO)
            {
                i++;
            }
            if (i == 3) { return true; }
            i = 0;
            while (i < 3 && Board[i, col] == XorO)
            {
                i++;
            }
            if (i == 3) { return true; }
            if (row == col)
            {
                if (Board[0, 0] == Board[1, 1] && Board[1, 1] == Board[2, 2]) { return true; }
            }
            if (row + col == 2)
            {

                if (Board[0, 2] == Board[1, 1] && Board[1, 1] == Board[2, 0]) { return true; }
            }
            return false;
        }
        public static void HowToPlay()
        {
            Console.WriteLine("\tTic-Tac-Toe\n\nHow to play:\nChoose the cell number, the cell sequence is shown below");
            Console.WriteLine(" 1 | 2 | 3 ");
            Console.WriteLine("--- --- ---");
            Console.WriteLine(" 4 | 5 | 6 ");
            Console.WriteLine("--- --- ---");
            Console.WriteLine(" 7 | 8 | 9 ");
            Console.WriteLine("\nFor example I want to choose the cell which is in the middle, its number is 5:\n\n" +
                "After selection\n");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("--- --- ---");
            Console.WriteLine("   | X |   ");
            Console.WriteLine("--- --- ---");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("\nPRESS ANY KEY TO START");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
