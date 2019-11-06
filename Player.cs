using System.Collections.Generic;
using System;

namespace StoryBook
{
    public class Player
    {
        public Player(string characterName)
        {
            name = characterName;
            health = 10;
            playerInventory = new Inventory();
            equippedItem = "";

        }
        public void ViewInventory()
        {
            var itemList = new List<string>();

            if(playerInventory.sword.obtained == true)
            {
                itemList.Add(playerInventory.sword.name);
            }

            for(var i = 0; i < itemList.Count; i++)
            {
                System.Console.WriteLine($"\nYou have a {itemList[i]}");
            }

            System.Console.WriteLine("Select an item? y/n");
            var inputChoice = Console.ReadLine();

            if(inputChoice == "y")
            {
                System.Console.WriteLine("\nWhich item do you want to equip?");
                inputChoice = Console.ReadLine();

                for(var i = 0; i < itemList.Count; i++)
                {
                    if(inputChoice == itemList[i])
                    {
                        System.Console.WriteLine($"\nYou have equipped a {itemList[i]}");
                        playerInventory.sword.equipped = true;
                        equippedItem = $"{itemList[i]}";
                        return;
                    }
                }
            }
            else if(inputChoice == "n")
            {

            }
            else
            {

            }
        }
        public string name;
        public double health;
        public Inventory playerInventory;
        public string equippedItem;
    }
}