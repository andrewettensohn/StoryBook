using System;

namespace StoryBook
{
    public class LevelOutside
    {
        public static void TombEntrance(Player player)
        {
            while(true)
            {
                System.Console.WriteLine("\nThe journey to the tomb has been long but you have finally arrived.\n" +
                "Before you lies the entrance, a great stone door covered in tangled vines.");

                System.Console.WriteLine("What do you wish to do?");
                System.Console.WriteLine("1: Enter the tomb.");
                System.Console.WriteLine("2: Inspect the door.");
                var inputChoice = Console.ReadLine();

                if(inputChoice == "1")
                {
                    Levelfountian.tombAnnex(player);
                    break;
                }
                else if (inputChoice == "2")
                {
                    System.Console.WriteLine("\nThe stone door has been carved with the image of a warrior pointing his blade toward the sun.");
                }
                else 
                {

                }
            }
        }
    }
}