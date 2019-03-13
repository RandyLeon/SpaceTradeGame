using System;

namespace SpaceTradeGame
{
    internal class MovementAspect
    {
        public MovementAspect()
        {
            int r = 0;
            int sides = 20;
            ConsoleKeyInfo Keyinfo;


            do
            {
                Keyinfo = Console.ReadKey(true);
                Console.Clear();

                switch (Keyinfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        sides++;
                        Console.SetCursorPosition(sides, 10);
                        Console.Write("._.");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        sides--;
                        Console.SetCursorPosition(sides, 10);
                        Console.Write("._.");
                        break;
                    case ConsoleKey.UpArrow:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        sides--;
                        Console.SetCursorPosition(10, sides);
                        Console.Write("._.");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        sides++;
                        Console.SetCursorPosition(10, sides);
                        Console.Write("._.");
                        break;


                }

            } while (r == 0);

            Console.ReadLine();
        }
    }
}