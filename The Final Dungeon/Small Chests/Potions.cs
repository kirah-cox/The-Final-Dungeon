﻿using AllCreations;
using MyTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class Potions
    {
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
                    break;
                case PotionType.Strength:
                    Potion = PotionType.Strength;
                    break;
                case PotionType.Mana:
                    Potion = PotionType.Mana;
                    break;
                case PotionType.Luck:
                    Potion = PotionType.Luck;
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
                UseHealthPotion(player);
                return true;
            }
            else if (potion == PotionType.Strength && UsedStrengthPotion || potion == PotionType.Mana && UsedManaPotion || potion == PotionType.Luck && UsedLuckPotion)
            {
                Console.WriteLine("You have already used this type of potion during the battle.");
                MainBattle.CursorPosition++;
                AlreadyUsedPotion = true;
                return true;
            }
            else if (potion == PotionType.Strength && !UsedStrengthPotion)
            {
                UseStrengthPotion(player);
                return true;
            }
            else if (potion == PotionType.Mana && !UsedManaPotion)
            {
                UseManaPotion(player);
                return true;
            }
            else if (potion == PotionType.Luck && !UsedLuckPotion)
            {
                UseLuckPotion(player);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void UseHealthPotion(Player player)
        {
            if ((5 * player.Level) - 5 > 0)
            {
                player.Health += 25;
            }
            else
            {
                player.Health = 25;
            }

            Console.WriteLine($"You drank a health potion! Your Health is now {player.Health}.");
            MainBattle.CursorPosition++;

            player.PotionInventory[PotionType.Health]--;
        }

        public static void UseStrengthPotion(Player player)
        {
            player.Strength += 10;

            UsedStrengthPotion = true;

            Console.WriteLine($"You drank a strength potion! Your Strength is now {player.Strength}.");
            MainBattle.CursorPosition++;

            player.PotionInventory[PotionType.Strength]--;
        }

        public static void UseManaPotion(Player player)
        {
            player.Mana += 10;

            UsedManaPotion = true;

            Console.WriteLine($"You drank a mana potion! Your Mana is now {player.Mana}.");
            MainBattle.CursorPosition++;

            player.PotionInventory[PotionType.Mana]--;
        }

        public static void UseLuckPotion(Player player)
        {
            player.Luck += 10;

            UsedLuckPotion = true;

            Console.WriteLine($"You drank a luck potion! Your Luck is now {player.Luck}.");
            MainBattle.CursorPosition++;

            player.PotionInventory[PotionType.Luck]--;
        }
    }
}
