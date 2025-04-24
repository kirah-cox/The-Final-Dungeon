using AllCreations;
using AllMaps;
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

        public static bool PlayerUsingPotion { get; set; } = false;

        public static bool UsingKey { get; set; } = false;

        public static async Task PlayerAndEnemyActions(Player player, Enemy enemy)
        {
            Console.SetCursorPosition(0, 0);

            CombatBoxes.DrawCombatBox(player, enemy);

            Console.SetCursorPosition(0, CursorPosition);

            if (!UsingKey)
            {
                PlayerAttackOrUseItems(player, enemy);
            }

            EnemyAttack(player, enemy);
        }

        public static async Task PlayerAttackOrUseItems(Player player, Enemy enemy)
        {
            while (true)
            {
                var key = ConsoleKey.P;

                await Task.Run(() =>
                {
                    UsingKey = true;
                    key = Console.ReadKey(intercept: true).Key;
                    UsingKey = false;
                });

                if (key == ConsoleKey.D1)
                {
                    if (!PlayerUsingPotion)
                    {
                        await PlayerAttack(player, enemy);
                    }
                    break;
                }
                else if (key == ConsoleKey.D2)
                {
                    bool haveItems = false;
                    CorrectPotion = false;
                    if (player.PotionInventory.Count() >= 1)
                    {
                        haveItems = true;
                        while (true)
                        {
                            await PlayerUsePotion(player);
                            if (CorrectPotion)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        await Task.Run(() =>
                        {
                            Console.WriteLine("You do not have any items you can use.");
                            CursorPosition++;
                        });
                    }
                    if (!Potions.AlreadyUsedPotion && haveItems)
                    {
                        break;
                    }
                }
            }
        }

        public static async Task PlayerAttack(Player player, Enemy enemy)
        {
            int playerAttack = player.Attack(player.Weapon);
            Console.WriteLine($"You attacked {enemy.Class} with a damage of {playerAttack}.");
            CursorPosition++;
            enemy.TakeDamage(playerAttack);
            Console.SetCursorPosition(0, 0);
            CombatBoxes.DrawCombatBox(player, enemy);
            Console.SetCursorPosition(0, CursorPosition);
            Thread.Sleep(500);
        }

        public static async Task EnemyAttack(Player player, Enemy enemy)
        {
            Random random = new Random();
            int randomDely = random.Next(500, 4001);
            Thread.Sleep(randomDely);

            if (enemy.Health > 0)
            {
                int enemyAttack = enemy.Attack();
                Console.WriteLine($"{enemy.Class} attacks you with a damage of {enemyAttack}.");
                CursorPosition++;
                player.TakeDamage(enemyAttack);
                Console.SetCursorPosition(0, 0);
                CombatBoxes.DrawCombatBox(player, enemy);
                Console.SetCursorPosition(0, CursorPosition);
            }
        }

        public static async Task PlayerUsePotion(Player player)
        {
            PlayerUsingPotion = true;
            Console.WriteLine("Which item would you like to use?");
            CursorPosition++;

            int lineNumber = 0;
            List<Potions.PotionType> potionTypes = new List<Potions.PotionType>();
            var orderedPotions = player.PotionInventory.OrderBy(potion => potion.Key).Where(potion => potion.Value != 0);
            foreach (var line in orderedPotions)
            {
                Console.WriteLine($"{lineNumber + 1}. {line.Key} Potion: {line.Value}");
                potionTypes.Add(line.Key);
                lineNumber++;
                CursorPosition++;
            }

            while (!CorrectPotion)
            {
                PotionChoice(player, potionTypes, lineNumber);
            }

            PlayerUsingPotion = false;
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
