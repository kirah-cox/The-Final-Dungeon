using AllCreations;
using AllMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootThings;
using System.Security.Cryptography.X509Certificates;

namespace MyTools
{
    public class Tools
    {
        public static int UpDown { get; set; } = 1;
        public static int LeftRight { get; set; } = 1;
        public static bool Up { get; set; } = false;
        public static bool Down { get; set; } = false;
        public static bool Left { get; set; } = false;
        public static bool Right { get; set; } = false;
        public static bool EncounteredEnemy { get; set; } = false;
        public static bool ChestEmpty { get; set; } = false;
        public static bool ObtainedKey { get; set; } = false;
        public static bool CrossedGap { get; set; } = false;
        public static bool ObtainedFeather { get; set; } = false;
        public static bool PushingBoulder { get; set; } = false;
        public static bool BoulderOverGap { get; set; } = false;
        public static int MapNumber { get; set; } = 0;

        public static void RandomEnemyEncounter()
        {
            Random random = new Random();
            int potentialEnemy = random.Next(1, 101);

            if (potentialEnemy <= 1)
            {
                EncounteredEnemy = true;
            }
        }
        public static void Battle(Player player, Enemy enemy)
        {
            Console.WriteLine($"You have encountered {enemy.Class}.");
            PressEnter();

            while (enemy.Health > 0 && player.Health > 0)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Your health: {player.Health}");
                    Console.WriteLine($"Enemy health: {enemy.Health}");
                    Console.WriteLine("1: Attack");
                    Console.WriteLine("2: Use Item");

                    var key = Console.ReadKey().Key;

                    if (key == ConsoleKey.D1)
                    {
                        int playerAttack = player.Attack();
                        Console.WriteLine($"You attacked {enemy.Class} with a damage of {playerAttack}.");
                        enemy.TakeDamage(playerAttack);
                        Thread.Sleep(2000);
                        break;
                    }
                    else if (key == ConsoleKey.D2)
                    {
                        bool haveItems = false;
                        int lineNumber = 1;
                        if (player.PotionInventory.Count() >= 1)
                        {
                            haveItems = true;
                            while (true)
                            {
                                List<Potions.PotionType> potionTypes = new List<Potions.PotionType>();

                                Console.WriteLine("Which item would you like to use?");

                                var orderedPotions = player.PotionInventory.OrderBy(potion => potion.Key).Where(potion => potion.Value != 0);
                                foreach (var line in orderedPotions)
                                {
                                    Console.WriteLine($"{lineNumber}. {line.Key} Potion: {line.Value}");
                                    potionTypes.Add(line.Key);
                                    lineNumber++;
                                }

                                bool correctPotion = false;
                                while (!correctPotion)
                                {
                                    var newKey = Console.ReadKey().Key;

                                    if (newKey == ConsoleKey.D1)
                                    {
                                        correctPotion = Potions.UsePotion(player, potionTypes[0]) ? true : false;
                                    }
                                    else if (newKey == ConsoleKey.D2 && lineNumber >= 2)
                                    {
                                        correctPotion = Potions.UsePotion(player, potionTypes[1]) ? true : false;
                                    }
                                    else if (newKey == ConsoleKey.D3 && lineNumber >= 3)
                                    {
                                        correctPotion = Potions.UsePotion(player, potionTypes[2]) ? true : false;
                                    }
                                    else if (newKey == ConsoleKey.D4 && lineNumber >= 4)
                                    {
                                        correctPotion = Potions.UsePotion(player, potionTypes[3]) ? true : false;
                                    }
                                }

                                if (correctPotion)
                                {
                                    break;
                                }

                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You do not have any items you can use.");
                            Thread.Sleep(2000);
                            PressEnter();
                        }

                        if (!Potions.AlreadyUsedPotion && haveItems)
                        {
                            break;
                        }
                    }

                    Console.Clear();
                }

                if (enemy.Health > 0)
                {
                    int enemyAttack = enemy.Attack();
                    Console.WriteLine($"{enemy.Class} attacks you with a damage of {enemyAttack}.");
                    Thread.Sleep(2000);
                    player.TakeDamage(enemyAttack);
                }
            }

            if (player.Health <= 0)
            {
                Console.WriteLine("You have died.");
                Environment.Exit(0);
            }

            player.GainExperience(enemy.Experience);
            Console.WriteLine($"You have defeated {enemy.Class} and have gained {enemy.Experience} experience.");

            if (Potions.UsedLuckPotion)
            {
                player.Luck -= 10;
                Potions.UsedLuckPotion = false;
            }

            if (Potions.UsedStrengthPotion)
            {
                player.Strength -= 10;
                Potions.UsedStrengthPotion = false;
            }

            if (Potions.UsedManaPotion)
            {
                player.Mana -= 10;
                Potions.UsedManaPotion = false;
            }

            PressEnter();

            Console.Clear();
        }

        public static void PressEnter()
        {
            Console.WriteLine("Press enter to continue.");

            bool enterPressed = false;
            while (!enterPressed)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    enterPressed = true;
                }
            }
        }
    }
}


