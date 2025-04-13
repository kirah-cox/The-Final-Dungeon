using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
        public double StrengthMultiplier { get; set; }
        public double ManaMultiplier { get; set; }
        public double LuckMultiplier { get; set; }
        public bool Equipped { get; set; } = false;

        public Weapons()
        {
            Name = "Unknown";
            StrenthRequirement = 0;
            ManaRequirement = 0;
            LuckRequirement = 0;
            StrengthMultiplier = 1;
            ManaMultiplier = 1;
            LuckMultiplier = 1;
            Equipped = false;
        }

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
                Console.WriteLine("2. No");

                var key = Console.ReadKey(intercept: true).Key;
                while (true)
                {
                    if (key == ConsoleKey.D1)
                    {
                        Console.WriteLine("Which weapon would you like to drop?");
                        int lineNumber = 1;

                        foreach (var item in player.WeaponInventory)
                        {
                            Console.WriteLine($"{lineNumber}. {item.Name}");
                            item.ViewWeaponStats();
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
            if (player.Strength < StrenthRequirement)
            {
                Console.WriteLine("You do not have the strength required to equip this weapon.");
            }
            if (player.Mana < ManaRequirement)
            {
                Console.WriteLine("You do not have the mana required to equip this weapon.");
            }
            if (player.Luck < LuckRequirement)
            {
                Console.WriteLine("You do not have the luck required to equip this weapon.");
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
