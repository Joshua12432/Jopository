using System;

namespace JSharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
                        Console.Title = "Game ConsoleV2";

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WindowHeight = 40;
            Console.WindowWidth = 40;
            

            Console.WriteLine("Program:Welcome To the Game C# LauncherV2");
            Console.WriteLine("Whats your fav coding language?");
            Console.ReadLine();
            Console.WriteLine("Cool! My fav is python.");
        }
    }
}