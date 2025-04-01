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

        public static int Attack(Player player, int rLuck)
        {
            bool luckDamage = false;

            switch (player.Luck)
            {
                case 1:
                    if (rLuck < 3)
                    {
                        luckDamage = true;
                    }
                    break;
                case (2 | 3):
                    if (rLuck < 5)
                    {
                        luckDamage = true;
                    }
                    break;
                case (4 | 5 | 6):
                    if (rLuck < 7)
                    {
                        luckDamage = true;
                    }
                    break;
                case (7 | 8 | 9 | 10):
                    if (rLuck < 9)
                    {
                        luckDamage = true;
                    }
                    break;
                case (11 | 12 | 13 | 14 | 15 | 16):
                    if (rLuck < 11)
                    {
                        luckDamage = true;
                    }
                    break;
                case (17 | 18 | 19 | 20 | 21 | 22 | 23):
                    if (rLuck < 16)
                    {
                        luckDamage = true;
                    }
                    break;
                case (24 | 25):
                    if (rLuck < 16)
                    {
                        luckDamage = true;
                    }
                    break;
                default:
                    if (rLuck < 21)
                    {
                        luckDamage = true;
                    }
                    break;
            }

            int damage = player.Strength + player.Mana;
            int totalDamage = 0;

            if (luckDamage)
            {
                totalDamage = damage * 2;
            }
            else
            {
                totalDamage = damage;
            }

            return totalDamage;
        }
    }
}
