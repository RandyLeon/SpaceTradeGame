using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTradeGame
{
    class TitleScreen
    {
       public static void Title()
        {
            var Home = 1;

            if (Home == 1)
            {


               // Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                // Console.Title = "ASCII Art";
                Console.WriteLine(@"


      ███████╗ ██████╗ ██╗         ████████╗██████╗  █████╗ ██████╗ ███████╗██████╗                =        
      ██╔════╝██╔═══██╗██║         ╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗              /.\
      ███████╗██║   ██║██║            ██║   ██████╔╝███████║██║  ██║█████╗  ██████╔╝             /...\
      ╚════██║██║   ██║██║            ██║   ██╔══██╗██╔══██║██║  ██║██╔══╝  ██╔══██╗            /.....\
      ███████║╚██████╔╝███████╗       ██║   ██║  ██║██║  ██║██████╔╝███████╗██║  ██║           |... ...|        
      ╚══════╝ ╚═════╝ ╚══════╝       ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚══════╝╚═╝  ╚═╝           |..   ..| 
                                                                                               |.     .|
                                                                                               |..   ..|
                                                                                               |... ...|     
                                                                                             _/.........\_
                                                                                            /.\........./.\
                                                                                           /...\......./...\
                                                                                          /.....\...../.....\
                                                                                         /_______\.../_______\
                                                                                                  \./
                                                                                                   _
                                                                                                  ___
                                                                                                _______ ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Welcome to Sol Trader young adventurer!");
                Console.WriteLine("The year is 2147. Exploring the stars has become a hobby for many as space travel becomes commonplace.");
                Console.WriteLine("You have just graduated from the stellar business academy with a degree in intergalatic finance! Congratulations!");
                Console.WriteLine("Your father rewards you with your first spaceship. Will you fulfill your dreams of becoming a space trading mogul?");
                Console.WriteLine("Or will you die alone, penniless, drifting through space, living through your dreams in crysosleep?\n");
                Console.WriteLine("Choose your path. Your journey begins now!\n");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Press enter to Begin...");
                Console.ReadKey();
                Console.Clear();
            }
        }
                                                               
    }
}
