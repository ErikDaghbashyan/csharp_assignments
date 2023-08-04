namespace Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToe.HowToPlay();

            Console.WriteLine("Write the name of the player who will play first(with X): ");
            string Player1 = Console.ReadLine();
            Console.WriteLine("Write the name of the second player (with O):");
            string Player2 = Console.ReadLine();

            TicTacToe game = new TicTacToe(Player1,Player2);

            ConsoleKey key;
            do
            {
                game.Play();

                Console.WriteLine("\nIf you want to play again press Enter, for exit press Escape");
                key = Console.ReadKey().Key;
                Console.Clear();
            } while (key != ConsoleKey.Escape);
            Console.WriteLine("HHave a nice day:)");
        }
    }
}