﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootThings;

namespace AllCreations
{
    public abstract class Creations
    {
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Mana { get; set; }
        public int Luck { get; set; }
        public int Experience { get; set; }
        public Weapons Weapon { get; set; }



        public int Attack(Weapons weapon = null)
        {
            Random random = new Random();
            int rLuck = random.Next(1, 101);
            bool luckDamage = false;
            int luck;

            if (weapon != null)
            {
                luck = (int)Math.Round(Luck * weapon.LuckMultiplier);
            }
            else
            {
                luck = Luck;
            }

            switch (luck)
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

            int damage;

            if (weapon != null)
            {
                damage = (int)Math.Round(Strength * weapon.StrengthMultiplier) + (int)Math.Round(Mana * weapon.ManaMultiplier);
            }
            else
            {
                damage = Strength + Mana;
            }

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

        public void TakeDamage(int damageTaken)
        {
            if (Health - damageTaken < 0)
            {
                Health = 0;
                return;
            }

            Health -= damageTaken;
        }
    }

    public enum PlayerClass
    {
        Warrior,
        Wizard,
        Rogue,
    }

    public enum EnemyClass
    {
        
        None,

        Spider,
        Viper,
        Frog,
        Rat,
        Slime,
        KingFrog,

        Imp,
        Goblin,
        Kobold,
        Skeleton,
        Witch,
        GiantSpider,

        BoneWarrior,
        Vampire,
        Orc,
        EvilEnt,
        Warlock,
        DungeonKing,
    }
}
