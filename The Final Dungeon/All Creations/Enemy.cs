using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using LootThings;

namespace AllCreations
{
    public class Enemy : Creations
    {
        public EnemyClass Class { get; set; }
        public Random RandomExperience { get; set; } = new Random();
        public Random WeaponNumber { get; set; } = new Random();
        public Random RandomDropWeapon { get; set; } = new Random();
        public bool DropWeapon { get; set; } = false;

        public Enemy(EnemyClass enemyClass)
        {
            switch (enemyClass)
            {
                case EnemyClass.Spider:
                    ConstructSpider();
                    break;
                case EnemyClass.Viper:
                    ConstructViper();
                    break;
                case EnemyClass.Frog:
                    ConstructFrog();
                    break;
                case EnemyClass.Rat:
                    ConstructRat();
                    break;
                case EnemyClass.Slime:
                    ConstructSlime();
                    break;
                default:
                    break;
            }
        }

        public void ConstructSpider()
        {
            Health = 12;
            Class = EnemyClass.Spider;
            Strength = 3;
            Mana = 2;
            Luck = 15;
            Random randomSpider = new Random();
            Experience = RandomExperience.Next(5, 8);
            Weapon = new SpiderWeapon(WeaponNumber.Next(1, 4));
            if(RandomDropWeapon.Next(1, 101) <= 100)
            {
                DropWeapon = true;
            }
        }

        public void ConstructViper()
        {
            Health = 15;
            Class = EnemyClass.Viper;
            Strength = 3;
            Mana = 3;
            Luck = 7;
            Random randomViper = new Random();
            Experience = RandomExperience.Next(12, 16);
            Weapon = new ViperWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 100)
            {
                DropWeapon = true;
            }
        }

        public void ConstructFrog()
        {
            Health = 4;
            Class = EnemyClass.Frog;
            Strength = 1;
            Mana = 1;
            Luck = 25;
            Random randomFrog = new Random();
            Experience = RandomExperience.Next(3, 6);
            Weapon = new FrogWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 100)
            {
                DropWeapon = true;
            }
        }

        public void ConstructRat()
        {
            Health = 10;
            Class = EnemyClass.Rat;
            Strength = 3;
            Mana = 1;
            Luck = 1;
            Random randomRat = new Random();
            Experience = RandomExperience.Next(3, 6);
            Weapon = new RatWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 100)
            {
                DropWeapon = true;
            }
        }

        public void ConstructSlime()
        {
            Health = 8;
            Class = EnemyClass.Slime;
            Strength = 3;
            Mana = 5;
            Luck = 15;
            Random randomSlime = new Random();
            Experience = RandomExperience.Next(8, 12);
            Weapon = new SlimeWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 100)
            {
                DropWeapon = true;
            }
        }

        public static Enemy EnemyEncounter()
        {
            Console.Clear();

            Enemy enemy = new Enemy(EnemyClass.None);
            Random random = new Random();
            int randomEnemy = random.Next(1, 101);

            if (randomEnemy < 21)
            {
                enemy = new Enemy(EnemyClass.Viper);
            }
            else if (randomEnemy < 41)
            {
                enemy = new Enemy(EnemyClass.Frog);
            }
            else if (randomEnemy < 61)
            {
                enemy = new Enemy(EnemyClass.Slime);
            }
            else if (randomEnemy < 81)
            {
                enemy = new Enemy(EnemyClass.Spider);
            }
            else if (randomEnemy < 101)
            {
                enemy = new Enemy(EnemyClass.Rat);
            }
            return enemy;
        }
    }
}
