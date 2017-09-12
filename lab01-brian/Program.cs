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
            GameStart(Console.ReadLine());
            
        }

        static void GameStart(string yesOrNo)
        {
            if (!string.IsNullOrEmpty(yesOrNo))
            {
                string answer = yesOrNo.Trim().ToLower();
                if (answer == "y" || answer == "yes")
                {
                    Console.WriteLine();
                    Console.WriteLine("Rad, Let's Play!");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    YesNoQuestions();
                }
                else if (answer == "n" || answer == "no")
                {
                    Console.WriteLine("Sad Day ...");
                    System.Threading.Thread.Sleep(1000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine(@"Try again ...
Are you ready to play?
Y/n: ");
                    GameStart(Console.ReadLine());
                }
            }
        }
        static void YesNoQuestions()
        {
            Console.WriteLine("works!");
        }
    }
}
