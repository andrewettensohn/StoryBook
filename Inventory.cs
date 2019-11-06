using System;
using System.Collections.Generic;

namespace StoryBook
{
    public class Inventory
    {
        public Sword sword {get; set;}
        public Inventory()
        {
            sword = new Sword();

            

        }
        // public static void ViewInventory()
        // {
        //     var itemList = new List<string>();
        //     itemList.Add(sword.name);

        // }

    }

    public class Sword
    {
        public string name = "Sword";
        public bool obtained = true;
        public bool equipped = false;
        public int attack = 4;
        public int defense = 1;
        public int weight = 5;
    }
}