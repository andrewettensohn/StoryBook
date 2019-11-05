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
            inventory = new List<object>();

            var blade = new Sword();
            inventory.Add(blade);

        }
        public string name;
        public double health;
        public List<object> inventory;
    }
}