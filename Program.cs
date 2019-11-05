using System;

namespace StoryBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to StoryBook, an adventure game.");
            System.Console.Write("Enter NEW to start a new game. Enter LOAD to continue an existing game: ");
            var inputChoice = Console.ReadLine();

            if(inputChoice == "NEW")
            {
                CharacterCreation.NewCharacter();
            }
            else if(inputChoice == "LOAD")
            {

            }
            else
            {

            }
        }
    }
}
