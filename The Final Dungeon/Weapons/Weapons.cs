﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllCreations;
using MyTools;

namespace LootThings
{
    public class Weapons
    {
        public string Name { get; set; }
        public int StrenthRequirement { get; set; }
        public int ManaRequirement { get; set; }
        public int LuckRequirement { get; set; }
        public int StrengthMultiplier { get; set; }
        public int ManaMultiplier { get; set; }
        public int LuckMultiplier { get; set; }
        public bool Equipped { get; set; } = false;

        public static void AddOrDropWeapon(Player player, Enemy enemy)
        {
            if (player.WeaponInventory.Count < 5)
            {
                if (!player.WeaponInventory.Contains(enemy.Weapon))
                {
                    player.WeaponInventory.Add(enemy.Weapon);
                    Console.WriteLine($"{enemy.Weapon.Name} has been added to your inventory.");
                }
                else
                {
                    Console.WriteLine("You already have this weapon in your inventory.");
                }
            }
            else if (player.WeaponInventory.Count >= 5)
            {
                Console.WriteLine("You cannot hold more than 5 weapons. Would you like to drop another weapon?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("1. No");

                var key = Console.ReadKey().Key;
                while (true)
                {
                    if (key == ConsoleKey.D1)
                    {
                        Console.WriteLine("Which weapon would you like to drop?");
                        int lineNumber = 1;

                        foreach (var item in player.WeaponInventory)
                        {
                            Console.WriteLine($"{lineNumber}. {item.Name}");
                            lineNumber++;
                        }

                        var newKey = Console.ReadKey().Key;
                        while (true)
                        {
                            if(newKey == ConsoleKey.D1)
                            {
                                player.WeaponInventory.Remove(player.WeaponInventory[0]);
                                Console.WriteLine($"{player.WeaponInventory[0].Name} has been removed from your inventory.");
                                break;
                            }
                            else if (newKey == ConsoleKey.D2)
                            {
                                player.WeaponInventory.Remove(player.WeaponInventory[1]);
                                Console.WriteLine($"{player.WeaponInventory[1].Name} has been removed from your inventory.");
                                break;
                            }
                            else if (newKey == ConsoleKey.D3)
                            {
                                player.WeaponInventory.Remove(player.WeaponInventory[2]);
                                Console.WriteLine($"{player.WeaponInventory[2].Name} has been removed from your inventory.");
                                break;
                            }
                            else if (newKey == ConsoleKey.D4)
                            {
                                player.WeaponInventory.Remove(player.WeaponInventory[3]);
                                Console.WriteLine($"{player.WeaponInventory[3].Name} has been removed from your inventory.");
                                break;
                            }
                            else if(newKey == ConsoleKey.D5)
                            {
                                player.WeaponInventory.Remove(player.WeaponInventory[4]);
                                Console.WriteLine($"{player.WeaponInventory[4].Name} has been removed from your inventory.");
                                break;
                            }
                        }

                        player.WeaponInventory.Add(enemy.Weapon);
                        Console.WriteLine($"{enemy.Weapon.Name} has been added to your inventory.");
                        Tools.PressEnter();
                        break;
                    }
                    else if (key == ConsoleKey.D2)
                    {
                        Console.WriteLine($"You have left {enemy.Weapon.Name} where you found it.");
                        Tools.PressEnter();
                        break;
                    }
                }
            }
        }

        public void EquipWeapon(Player player, Weapons weapon)
        {
            if (player.Strength >= StrenthRequirement && player.Mana >= ManaRequirement && player.Luck >= LuckRequirement)
            {
                Equipped = true;
                player.Weapon = weapon;
                Console.WriteLine($"You have equipped {weapon.Name}.");
            }
            else
            {
                Console.WriteLine("You do not have the stats requied to equip this weapon.");
            }
        }

        public void ViewWeaponStats()
        {
            Console.WriteLine("Stats:");
            Console.WriteLine($"    Strength Requirement: {StrenthRequirement}");
            Console.WriteLine($"    Mana Requirement: {ManaRequirement}");
            Console.WriteLine($"    Luck Requirement: {LuckRequirement}");
        }

        public enum LevelOneSpiderWeapons
        {
            PincerKnife,
            OrbofManyEyes,
            WebbedHammer,
        }

        public enum LevelOneViperWeapons
        {
            FangedDagger,
            FangStaff,
            SpikedMace,
        }

        public enum LevelOneFrogWeapons
        {
            FlySnatcherDagger,
            OrbofBleps,
            LilyAxe,
        }

        public enum LevelOneRatWeapons
        {
            KnawedKnife,
            TailStaff,
            HairyAxe,
        }

        public enum LevelOneSlimeWeapons
        {
            SlimyDagger,
            OrbofSlime,
            WigglyLongSword,
        }
    }
}
