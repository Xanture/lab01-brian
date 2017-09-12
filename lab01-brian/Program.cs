using System;

namespace lab01_brian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Player Name: ");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName);
            Console.WriteLine();
            Console.WriteLine($"Hello {player.UserName} welcome to my game!");
            Console.Write(@"Are you ready to play?
Y/n: ");
            Console.ReadLine();

        }
    }
}
