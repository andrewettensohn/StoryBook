using System;

namespace StoryBook
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        public static void menu()
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

//figure out how to make the enemy class better/revise combat
