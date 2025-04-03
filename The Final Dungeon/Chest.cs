using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllCreations;
using MyTools;

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
            }
            else
            {
                Console.WriteLine($"You have found {randomPotionAmount} {randomPotionType} potions!");
            }

            if (!player.PotionInventory.ContainsKey(randomPotionType))
            {
                player.PotionInventory.Add(randomPotionType, randomPotionAmount);
            }
            else
            {
                player.PotionInventory[randomPotionType] += randomPotionAmount;
            }

            Tools.PressEnter();

            Console.Clear();
        }
    }
}
