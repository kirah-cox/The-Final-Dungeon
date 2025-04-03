using AllCreations;
using MyTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class Potions
    {
        public int HealthGained {  get; set; }
        public int StrengthGained {  get; set; }
        public int ManaGained {  get; set; }
        public int LuckGained {  get; set; }
        public PotionType Potion {  get; set; }
        public static bool UsedStrengthPotion { get; set; } = false;
        public static bool UsedManaPotion { get; set; } = false;
        public static bool UsedLuckPotion { get; set; } = false;
        public static bool AlreadyUsedPotion { get; set; } = false;

        public enum PotionType
        {
            None,
            Health,
            Strength,
            Mana,
            Luck,
        }

        public Potions(PotionType potionType)
        {
            switch (potionType)
            {
                case PotionType.Health:
                    Potion = PotionType.Health;
                    HealthGained = 25;
                    StrengthGained = 0;
                    ManaGained = 0;
                    LuckGained = 0;
                    break;
                case PotionType.Strength:
                    Potion = PotionType.Strength;
                    HealthGained = 0;
                    StrengthGained = 10;
                    ManaGained = 0;
                    LuckGained = 0;
                    break;
                case PotionType.Mana:
                    Potion = PotionType.Mana;
                    HealthGained = 0;
                    StrengthGained = 0;
                    ManaGained = 10;
                    LuckGained = 0;
                    break;
                case PotionType.Luck:
                    Potion = PotionType.Luck;
                    HealthGained = 25;
                    StrengthGained = 0;
                    ManaGained = 0;
                    LuckGained = 10;
                    break;
            }
        }

        public static PotionType RandomPotionType()
        {
            Random randomPotion = new Random();
            int typeOfPotion = randomPotion.Next(1, 5);

            PotionType potion = PotionType.None;

            switch (typeOfPotion)
            {
                case 1:
                    potion = PotionType.Health;
                    break;
                case 2:
                    potion = PotionType.Strength;
                    break;
                case 3:
                    potion = PotionType.Mana;
                    break;
                case 4:
                    potion = PotionType.Luck;
                    break;
                default:
                    break;
            }

            return potion;
        }

        public static int RandomPotionAmount()
        {
            Random randomAmount = new Random();
            int potionAmount = randomAmount.Next(1, 3);

            return potionAmount;
        }

        public static bool UsePotion(Player player, PotionType potion)
        {
            AlreadyUsedPotion = false;

            if (potion == PotionType.Health)
            {
                if(player.Health > 25)
                {
                    player.Health += 25;
                }
                else
                {
                    player.Health = 25;
                }

                Console.WriteLine($"You drank a health potion! Your Health is now {player.Health}.");
                Tools.PressEnter();

                player.PotionInventory[PotionType.Health]--;
                return true;
            }
            else if (potion == PotionType.Strength && UsedStrengthPotion || potion == PotionType.Mana && UsedManaPotion || potion == PotionType.Luck && UsedLuckPotion)
            {
                Console.WriteLine("You have already used this type of potion during the battle.");
                Tools.PressEnter();
                AlreadyUsedPotion = true;
                return true;
            }
            else if (potion == PotionType.Strength && !UsedStrengthPotion)
            {
                player.Strength += 10;

                UsedStrengthPotion = true;

                Console.WriteLine($"You drank a strength potion! Your Strength is now {player.Strength}.");
                Tools.PressEnter();

                player.PotionInventory[PotionType.Strength]--;
                return true;
            }
            else if (potion == PotionType.Mana && !UsedManaPotion)
            {
                player.Mana += 10;

                UsedManaPotion = true;

                Console.WriteLine($"You drank a mana potion! Your Mana is now {player.Mana}.");
                Tools.PressEnter();

                player.PotionInventory[PotionType.Mana]--;
                return true;
            }
            else if (potion == PotionType.Luck && !UsedLuckPotion)
            {
                player.Luck += 10;

                UsedLuckPotion = true;

                Console.WriteLine($"You drank a luck potion! Your Luck is now {player.Luck}.");
                Tools.PressEnter();

                player.PotionInventory[PotionType.Luck]--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
