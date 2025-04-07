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
                BattleMethods.PlayerAndEnemyActions(player, enemy);
            }

            if (player.Health <= 0)
            {
                Console.WriteLine("You have died.");
                Environment.Exit(0);
            }

            player.GainExperience(enemy.Experience);
            Console.WriteLine($"You have defeated {enemy.Class} and have gained {enemy.Experience} experience.");

            BattleMethods.ResetPotions(player);

            PressEnter();

            Console.Clear();
        }
    }
}
