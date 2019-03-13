using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTradeGame
{
    class Intro_Story
    {

        public void Story()
        {
            Console.WriteLine(nameOfPlayer());
            Console.WriteLine($"Welcome to Pull-A-Ship, your galaxies number one" +
                              $"space ship dealer. Are you looking to get your very own pre-owned vehicle today {yesOrNo()}, " +
                              $"That is great to come right this way, here is our absolute finest in stock at the moment {Ships()}");
            Console.ReadLine();
            
        }
        

        private int Ships()
        {
            Console.WriteLine("Choose your ship");
            Console.WriteLine("1. The silver trash bag");
            Console.WriteLine("2. The millennium dumpster");
            Console.WriteLine("3. The recycling bin");
            var ship = int.Parse(Console.ReadLine());

            switch (ship)
            {
                case 1:
                    Console.WriteLine("You have chosen The silver trash bag, all sales are final.");
                    break;
                case 2:
                    Console.WriteLine("You have chosen The millenium dumpster, all sales are final.");
                    break;
                case 3:
                    Console.WriteLine("You have chosen The recycling bin, all sales are final.");
                    break;
            }
            return ship;
        }

        private int nameOfPlayer()
        {
            Console.WriteLine("Enter Name great adventurer");
            var name = int.Parse(Console.ReadLine());
            Console.WriteLine(name);
            return name;
        }

        private int yesOrNo()
        {
            Console.WriteLine("y/n");
            var choice = int.Parse(Console.ReadLine());
            return choice;
           
        }
    }
}
