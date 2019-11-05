using System;
using System.Collections.Generic;

namespace StoryBook
{
    public class Combat
    {
        public static void start(Player player)
        {
            Random rnd = new Random();
            int intitative = rnd.Next(10);
            if(intitative > 5)
            {
                System.Console.WriteLine("You attack first!");
                playerAttack(player);
            }
            else
            {
                System.Console.WriteLine("The enemy attacks first!");
            }
        }
        public static void playerAttack(Player player)
        {
            System.Console.WriteLine("1: Open Inventory");
            System.Console.WriteLine("What action do you take?");
            var inputChoice = Console.ReadLine();

            if(inputChoice == "1")
            {
                foreach(item in player.inventory)
                {
                    System.Console.WriteLine($"");
                }
            }

        }
    }
}