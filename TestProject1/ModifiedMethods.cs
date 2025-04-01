using AllCreations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class ModifiedMethods
    {
        public static void LevelUp(ConsoleKey key, Player player)
        {
            if (!CalculateExperience(player))
            {
                return;
            }

            player.Level++;
            player.Health += 3;

            Console.WriteLine("You have gained a skillpoint! What skill would you like to level up?");
            Console.WriteLine("1: Strength");
            Console.WriteLine("1: Mana");
            Console.WriteLine("1: Luck");

            bool selectedSkill = false;
            while (!selectedSkill)
            {
                switch (key)
                {
                    case ConsoleKey.D1: //Strength
                        player.Strength++;
                        Console.WriteLine($"You have leveled up Strength. Your strength is now {player.Strength}.");
                        selectedSkill = true;
                        break;
                    case ConsoleKey.D2: //Mana
                        player.Mana++;
                        Console.WriteLine($"You have leveled up Mana. Your strength is now {player.Mana}.");
                        selectedSkill = true;
                        break;
                    case ConsoleKey.D3: //Luck
                        player.Luck++;
                        Console.WriteLine($"You have leveled up Luck. Your strength is now {player.Luck}.");
                        selectedSkill = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public static bool CalculateExperience(Player player)
        {
            player.ReadyToLevelUp = 25 * player.Level <= player.Experience ? true : false;

            return player.ReadyToLevelUp;
        }
    }
}
