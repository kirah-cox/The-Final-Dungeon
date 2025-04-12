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
    public class MainBattle : Tools
    {
        public static void RandomEnemyEncounter()
        {
            Random random = new Random();
            int potentialEnemy = random.Next(1, 101);

            if (potentialEnemy <= 5 && !BossFight)
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
                BattleMethods.PlayerAndEnemyActions(player, enemy);
            }

            if (player.Health <= 0)
            {
                Console.WriteLine("You have died.");
                Environment.Exit(0);
            }

            player.GainExperience(enemy.Experience);
            Console.WriteLine($"You have defeated {enemy.Class} and have gained {enemy.Experience} experience.");
            PressEnter();
            
            if (enemy.DropWeapon)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"The {enemy.Class} has dropped {enemy.Weapon.Name}. Would you like to add this to your inventory?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    Console.WriteLine("3. View Stats");

                    var key = Console.ReadKey(intercept: true).Key;

                    if (key == ConsoleKey.D1)
                    {
                        Weapons.AddOrDropWeapon(player, enemy);
                        break;
                    }
                    else if (key == ConsoleKey.D2)
                    {
                        Console.WriteLine($"You have left {enemy.Weapon.Name} where you found it.");
                        break;
                    }
                    else if (key == ConsoleKey.D3)
                    {
                        enemy.Weapon.ViewWeaponStats();
                        PressEnter();
                    }
                }
                PressEnter();
            }

            BattleMethods.ResetPotions(player);

            Console.Clear();
        }
    }
}
