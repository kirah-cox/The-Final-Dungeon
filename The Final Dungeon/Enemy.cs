using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AllCreations
{
    public class Enemy : Creations
    {
        public EnemyClass Class { get; set; }

        public Enemy(EnemyClass enemyClass)
        {
            switch (enemyClass)
            {
                case EnemyClass.Spider:
                    Health = 12;
                    Class = EnemyClass.Spider;
                    Strength = 3;
                    Mana = 2;
                    Luck = 15;
                    Random randomSpider = new Random();
                    Experience = randomSpider.Next(5, 8);
                    break;
                case EnemyClass.Viper:
                    Health = 15;
                    Class = EnemyClass.Viper;
                    Strength = 3;
                    Mana = 3;
                    Luck = 7;
                    Random randomViper = new Random();
                    Experience = randomViper.Next(12, 16);
                    break;
                case EnemyClass.Frog:
                    Health = 4;
                    Class = EnemyClass.Frog;
                    Strength = 1;
                    Mana = 1;
                    Luck = 25;
                    Random randomFrog = new Random();
                    Experience = randomFrog.Next(3, 6);
                    break;
                case EnemyClass.Rat:
                    Health = 10;
                    Class = EnemyClass.Rat;
                    Strength = 3;
                    Mana = 1;
                    Luck = 1;
                    Random randomRat = new Random();
                    Experience = randomRat.Next(3, 6);
                    break;
                case EnemyClass.Slime:
                    Health = 8;
                    Class = EnemyClass.Slime;
                    Strength = 3;
                    Mana = 5;
                    Luck = 15;
                    Random randomSlime = new Random();
                    Experience = randomSlime.Next(8, 12);
                    break;
                default:
                    break;
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
