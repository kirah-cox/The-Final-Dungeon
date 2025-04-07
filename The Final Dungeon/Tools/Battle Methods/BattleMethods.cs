using AllCreations;
using LootThings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class BattleMethods : MainBattle
    {
        public static bool CorrectPotion { get; set; } = false;

        public static void PlayerAndEnemyActions(Player player, Enemy enemy)
        {
            while (true)
            {
                PlayerChoiceStrings(player, enemy);
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.D1)
                {
                    PlayerAttack(player, enemy);
                    break;
                }
                else if (key == ConsoleKey.D2)
                {
                    bool haveItems = false;
                    CorrectPotion = false;
                    int lineNumber = 1;
                    if (player.PotionInventory.Count() >= 1)
                    {
                        haveItems = true;
                        while (true)
                        {
                            PlayerUsePotion(player, lineNumber);
                            if (CorrectPotion)
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
                EnemyAttack(player, enemy);
            }
        }

        public static void PlayerChoiceStrings(Player player, Enemy enemy)
        {
            Console.Clear();
            Console.WriteLine($"Your health: {player.Health}");
            Console.WriteLine($"Enemy health: {enemy.Health}");
            Console.WriteLine("1: Attack");
            Console.WriteLine("2: Use Potion");
        }

        public static void PlayerAttack(Player player, Enemy enemy)
        {
            int playerAttack = player.Attack();
            Console.WriteLine($"You attacked {enemy.Class} with a damage of {playerAttack}.");
            enemy.TakeDamage(playerAttack);
            Thread.Sleep(2000);
        }

        public static void EnemyAttack(Player player, Enemy enemy)
        {
            int enemyAttack = enemy.Attack();
            Console.WriteLine($"{enemy.Class} attacks you with a damage of {enemyAttack}.");
            Thread.Sleep(2000);
            player.TakeDamage(enemyAttack);
        }

        public static void PlayerUsePotion(Player player, int lineNumber)
        {
            Console.WriteLine("Which item would you like to use?");

            List<Potions.PotionType> potionTypes = new List<Potions.PotionType>();
            var orderedPotions = player.PotionInventory.OrderBy(potion => potion.Key).Where(potion => potion.Value != 0);
            foreach (var line in orderedPotions)
            {
                Console.WriteLine($"{lineNumber}. {line.Key} Potion: {line.Value}");
                potionTypes.Add(line.Key);
                lineNumber++;
            }

            while (!CorrectPotion)
            {
                PotionChoice(player, potionTypes, lineNumber);
            }
        }

        public static void PotionChoice(Player player, List<Potions.PotionType> potionTypes, int lineNumber)
        {
            var newKey = Console.ReadKey().Key;

            if (newKey == ConsoleKey.D1)
            {
                CorrectPotion = Potions.UsePotion(player, potionTypes[0]) ? true : false;
            }
            else if (newKey == ConsoleKey.D2 && lineNumber >= 2)
            {
                CorrectPotion = Potions.UsePotion(player, potionTypes[1]) ? true : false;
            }
            else if (newKey == ConsoleKey.D3 && lineNumber >= 3)
            {
                CorrectPotion = Potions.UsePotion(player, potionTypes[2]) ? true : false;
            }
            else if (newKey == ConsoleKey.D4 && lineNumber >= 4)
            {
                CorrectPotion = Potions.UsePotion(player, potionTypes[3]) ? true : false;
            }
        }

        public static void ResetPotions(Player player)
        {
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
        }
    }
}
