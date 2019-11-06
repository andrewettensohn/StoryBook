using System;
using System.Collections.Generic;
using System.Linq;

namespace StoryBook
{
    public class Combat
    {
        public static void start(Player player, string enemyType, int enemyCount)
        {
            var enemy = new Enemy(enemyType);

            Random rnd = new Random();
            int intitative = rnd.Next(10);
            if(intitative > 5)
            {
                System.Console.WriteLine("\nYou attack first!");
                playerAttack(player, enemy);
            }
            else
            {
                System.Console.WriteLine("\nThe enemy attacks first!");
                playerAttack(player, enemy);
            }
        }
        public static void playerAttack(Player player, Enemy enemy)
        {
            while(true)
            {
                if(player.health <= 0)
                {
                    System.Console.WriteLine("\nYou have died!");
                    Program.menu();
                    break;
                }

                if(enemy.goblin.health <= 0)
                {
                    break;
                }

                System.Console.WriteLine("1: Open Inventory");
                System.Console.WriteLine("2: View Health");
                if(player.equippedItem != ""){ System.Console.WriteLine($"3: Use {player.equippedItem}");}

                System.Console.WriteLine("What action do you take?");
                var inputChoice = Console.ReadLine();

                if(inputChoice == "1")
                {
                    player.ViewInventory();
                }
                else if(inputChoice == "2")
                {
                    System.Console.WriteLine($"You have {player.health} hitpoints");
                }
                else if(inputChoice == "3")
                {
                    Random chance = new Random();
                    int playerAttackChance = chance.Next(player.playerInventory.sword.attack);
                    int enemyDefenseChance = chance.Next(enemy.goblin.defense);
                    var dmg = playerAttackChance - enemyDefenseChance;
                    enemy.goblin.health = enemy.goblin.health - dmg;
                    System.Console.WriteLine($"You strike the goblin for {dmg} damage");

                    enemyAttack(player, enemy);
                }
            }
        }
        public static void enemyAttack(Player player, Enemy enemy)
        {
            if(enemy.goblin.health <= 0)
            {
                System.Console.WriteLine("You defeat the goblin!");
            }
            else if(enemy.goblin.health > 0)
            {
                Random chance = new Random();
                int enemyAttackChance = chance.Next(enemy.goblin.attack);
                int playerDefenseChance = chance.Next(player.playerInventory.sword.defense);
                var dmg = enemyAttackChance - playerDefenseChance;
                player.health = player.health - dmg;
                System.Console.WriteLine($"The goblin strikes you for {dmg} damage");

                playerAttack(player, enemy);
            }
        }
    }
}