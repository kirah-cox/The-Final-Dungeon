using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllCreations;

namespace LootThings
{
    class Chest
    {
        public static void AddPotion(Player player)
        {
            int randomPotionAmount = Potions.RandomPotionAmount();
            var randomPotionType = Potions.RandomPotionType();

            Console.Clear();
            if (randomPotionAmount == 1)
            {
                Console.WriteLine($"You have found a {randomPotionType} potion!");
                Thread.Sleep(2000); 
            }
            else
            {
                Console.WriteLine($"You have found {randomPotionAmount} {randomPotionType} potions!");
                Thread.Sleep(2000);
            }

            if (!player.PotionInventory.ContainsKey(randomPotionType))
            {
                player.PotionInventory.Add(randomPotionType, randomPotionAmount);
            }
            else
            {
                player.PotionInventory[randomPotionType] += randomPotionAmount;
            }

            Console.WriteLine("Press enter to continue.");
            bool enterPressed = false;
            while (!enterPressed)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    enterPressed = true;
                }
            }

            Console.Clear();
        }
    }
}
