using System;

namespace StoryBook
{
    public class Levelfountian
    {
        public static void tombAnnex(Player player)
        {
            System.Console.WriteLine("\n You push the stone door open. A goblin jumps from the darkness!");
            System.Console.WriteLine("What do you wish to do?");
            System.Console.WriteLine("1: Attack!");
            var inputChoice = Console.ReadLine();

            if(inputChoice == "1")
            {
                System.Console.WriteLine("woo!");
            }
            else
            {

            }
        }
    }
}