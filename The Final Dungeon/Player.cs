﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllCreations
{
    public class Player : Creations
    {
        public int Level { get; set; }
        public int Experience { get; set; }
        public PlayerClass Class { get; set; }
        public bool ReadyToLevelUp { get; set; } = false;

        public Player(PlayerClass playerclass)
        {
            Health = 10;
            Level = 1;
            Experience = 0;

            switch (playerclass)
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
            Health += 3;

            Console.WriteLine("You have gained a skillpoint! What skill would you like to level up?");
            Console.WriteLine("1: Strength");
            Console.WriteLine("1: Mana");
            Console.WriteLine("1: Luck");

            var key = Console.ReadKey().Key;
            bool selectedSkill = false;
            while (!selectedSkill)
            {
                switch (key)
                {
                    case ConsoleKey.D1:
                        Strength++;
                        Console.WriteLine($"You have leveled up Strength. Your strength is now {Strength}.");
                        selectedSkill = true;
                        break;
                    case ConsoleKey.D2:
                        Mana++;
                        Console.WriteLine($"You have leveled up Mana. Your strength is now {Mana}.");
                        selectedSkill = true;
                        break;
                    case ConsoleKey.D3:
                        Luck++;
                        Console.WriteLine($"You have leveled up Luck. Your strength is now {Luck}.");
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

    }

}
