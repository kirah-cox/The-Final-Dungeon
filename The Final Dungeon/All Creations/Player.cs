using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootThings;
using static LootThings.Potions;
using MyTools;

namespace AllCreations
{
    public class Player : Creations
    {
        public int Level { get; set; }
        public PlayerClass Class { get; set; }
        public bool ReadyToLevelUp { get; set; } = false;
        public int Gold { get; set; }

        public Dictionary<PotionType, int> PotionInventory = new Dictionary<PotionType, int>();

        public List<Weapons> WeaponInventory = new List<Weapons>();

        public Player(PlayerClass playerClass)
        {
            Health = 25;
            Level = 1;
            Experience = 0;

            switch (playerClass)
            {
                case PlayerClass.Warrior:
                    Class = PlayerClass.Warrior;
                    Strength = 5;
                    Mana = 1;
                    Luck = 1;
                    break;
                case PlayerClass.Wizard:
                    Class = PlayerClass.Wizard;
                    Strength = 1;
                    Mana = 5;
                    Luck = 1;
                    break;
                case PlayerClass.Rogue:
                    Class = PlayerClass.Rogue;
                    Strength = 1;
                    Mana = 1;
                    Luck = 5;
                    break;
                default:
                    break;
            }
        }

        public void LevelUp()
        {
            if (!CalculateExperience())
            {
                return;
            }

            Level++;
            Health = (5 * Level) + 20;

            Console.Clear();
            
            Console.WriteLine("You have gained a skillpoint! What skill would you like to level up?");
            Console.WriteLine("1: Strength");
            Console.WriteLine("2: Mana");
            Console.WriteLine("3: Luck");

            var key = Console.ReadKey(intercept: true).Key;
            bool selectedSkill = false;
            while (!selectedSkill)
            {
                switch (key)
                {
                    case ConsoleKey.D1:
                        Strength++;
                        Console.WriteLine($"You have leveled up Strength. Your strength is now {Strength}.");
                        Thread.Sleep(2000);
                        Tools.PressEnter();
                        Console.Clear();
                        selectedSkill = true;
                        break;
                    case ConsoleKey.D2:
                        Mana++;
                        Console.WriteLine($"You have leveled up Mana. Your strength is now {Mana}.");
                        Thread.Sleep(2000);
                        Tools.PressEnter();
                        Console.Clear();
                        selectedSkill = true;
                        break;
                    case ConsoleKey.D3:
                        Luck++;
                        Console.WriteLine($"You have leveled up Luck. Your strength is now {Luck}.");
                        Thread.Sleep(2000);
                        Tools.PressEnter();
                        Console.Clear();
                        selectedSkill = true;
                        break;
                    default:
                        break;
                }
            }

            ReadyToLevelUp = false;
        }

        public bool CalculateExperience()
        {
            ReadyToLevelUp = 25 * Level <= Experience ? true : false;

            return ReadyToLevelUp;
        }

        public void GainExperience(int experienceGained)
        {
            Experience += experienceGained;
        }

        public static void DisplayInventory(Player player)
        {
            Console.Clear();

            bool potionPressedEnter = false;

            while (true)
            {
                Console.WriteLine("1. Potions");
                Console.WriteLine("2. Weapons");
                var key = Console.ReadKey().Key;

                if (key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("Potions Inventory:");

                    if (player.PotionInventory.Count() == 0)
                    {
                        Console.WriteLine("You do not have any potions.");
                        break;
                    }

                    int potionsLineNumber = 0;
                    List<Potions.PotionType> potionTypes = new List<Potions.PotionType>();
                    var orderedPotions = player.PotionInventory.OrderBy(potion => potion.Key).Where(potion => potion.Value != 0);
                    foreach (var line in orderedPotions)
                    {
                        Console.WriteLine($"{potionsLineNumber + 1}. {line.Key} Potion: {line.Value}");
                        potionTypes.Add(line.Key);
                        potionsLineNumber++;
                    }
                    Console.WriteLine("Press enter to continue.");

                    while (true)
                    {
                        var newKey = Console.ReadKey(intercept: true).Key;

                        if (newKey == ConsoleKey.D1)
                        {
                            if (potionTypes[0] == Potions.PotionType.Health)
                            {
                                Potions.UseHealthPotion(player);
                                potionPressedEnter = true;
                                Tools.PressEnter();
                            }
                            else
                            {
                                Console.WriteLine("You can only use this potion in combat.");
                            }
                            break;
                        }
                        else if (newKey == ConsoleKey.D2 && potionsLineNumber >= 2)
                        {
                            if (potionTypes[1] == Potions.PotionType.Health)
                            {
                                Potions.UseHealthPotion(player);
                                potionPressedEnter = true;
                                Tools.PressEnter();
                            }
                            else
                            {
                                Console.WriteLine("You can only use this potion in combat.");
                            }
                            break;
                        }
                        else if (newKey == ConsoleKey.D3 && potionsLineNumber >= 3)
                        {
                            if (potionTypes[2] == Potions.PotionType.Health)
                            {
                                Potions.UseHealthPotion(player);
                                potionPressedEnter = true;
                                Tools.PressEnter();
                            }
                            else
                            {
                                Console.WriteLine("You can only use this potion in combat.");
                            }
                            break;
                        }
                        else if (newKey == ConsoleKey.D4 && potionsLineNumber >= 4)
                        {
                            if (potionTypes[3] == Potions.PotionType.Health)
                            {
                                Potions.UseHealthPotion(player);
                                potionPressedEnter = true;
                                Tools.PressEnter();
                            }
                            else
                            {
                                Console.WriteLine("You can only use this potion in combat.");
                            }
                            break;
                        }
                        else if (newKey == ConsoleKey.Enter)
                        {
                            potionPressedEnter = true;
                            break;
                        }
                    }
                    break;
                }
                else if (key == ConsoleKey.D2)
                {
                    Console.Clear();
                    Console.WriteLine("Weapons Inventory:");

                    if (player.WeaponInventory.Count() == 0)
                    {
                        Console.WriteLine("You do not have any weapons.");
                        break;
                    }

                    int weaponsLineNumber = 0;
                    foreach (var line in player.WeaponInventory)
                    {
                        Console.WriteLine($"{weaponsLineNumber + 1}. {line.Name}");
                        line.ViewWeaponStats();
                        weaponsLineNumber++;
                    }

                    while (true)
                    {
                        var newKey = Console.ReadKey(intercept: true).Key;

                        if (newKey == ConsoleKey.D1)
                        {
                            player.WeaponInventory[0].EquipWeapon(player, player.WeaponInventory[0]);
                            foreach(var weapon in player.WeaponInventory)
                            {
                                if (weapon != player.WeaponInventory[0])
                                {
                                    weapon.Equipped = false;
                                }
                            }
                            break;
                        }
                        else if (newKey == ConsoleKey.D2 && weaponsLineNumber >= 2)
                        {
                            player.WeaponInventory[1].EquipWeapon(player, player.WeaponInventory[1]);
                            foreach (var weapon in player.WeaponInventory)
                            {
                                if (weapon != player.WeaponInventory[1])
                                {
                                    weapon.Equipped = false;
                                }
                            }
                            break;
                        }
                        else if (newKey == ConsoleKey.D3 && weaponsLineNumber >= 3)
                        {
                            player.WeaponInventory[2].EquipWeapon(player, player.WeaponInventory[2]);
                            foreach (var weapon in player.WeaponInventory)
                            {
                                if (weapon != player.WeaponInventory[2])
                                {
                                    weapon.Equipped = false;
                                }
                            }
                            break;
                        }
                        else if (newKey == ConsoleKey.D4 && weaponsLineNumber >= 4)
                        {
                            player.WeaponInventory[3].EquipWeapon(player, player.WeaponInventory[3]);
                            foreach (var weapon in player.WeaponInventory)
                            {
                                if (weapon != player.WeaponInventory[3])
                                {
                                    weapon.Equipped = false;
                                }
                            }
                            break;
                        }
                        else if (newKey == ConsoleKey.D5 && weaponsLineNumber >= 5)
                        {
                            player.WeaponInventory[4].EquipWeapon(player, player.WeaponInventory[4]);
                            foreach (var weapon in player.WeaponInventory)
                            {
                                if (weapon != player.WeaponInventory[4])
                                {
                                    weapon.Equipped = false;
                                }
                            }
                            break;
                        }
                    }
                    break;
                }
                Console.Clear();
            }

            if (!potionPressedEnter)
            {
                Tools.PressEnter();
            }
            Console.Clear();
        }
    }
}
