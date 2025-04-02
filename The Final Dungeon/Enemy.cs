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
                case EnemyClass.Skeleton:
                    Health = 25;
                    Class = EnemyClass.Skeleton;
                    Strength = 7;
                    Mana = 2;
                    Luck = 2;
                    Random randomSkeleton = new Random();
                    Experience = randomSkeleton.Next(5, 8);
                    break;
                case EnemyClass.BoneWarrior:
                    Health = 40;
                    Class = EnemyClass.BoneWarrior;
                    Strength = 10;
                    Mana = 1;
                    Luck = 7;
                    Random randomBoneWarrior = new Random();
                    Experience = randomBoneWarrior.Next(12, 16);
                    break;
                case EnemyClass.EvilWitch:
                    Health = 40;
                    Class = EnemyClass.EvilWitch;
                    Strength = 1;
                    Mana = 10;
                    Luck = 7;
                    Random randomEvilWitch = new Random();
                    Experience = randomEvilWitch.Next(12, 16);
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
                case EnemyClass.GiantSpider:
                    Health = 30;
                    Class = EnemyClass.GiantSpider;
                    Strength = 6;
                    Mana = 5;
                    Luck = 15;
                    Random randomGiantSpider = new Random();
                    Experience = randomGiantSpider.Next(8, 12);
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

            if (randomEnemy < 11)
            {
                enemy = new Enemy(EnemyClass.BoneWarrior);
            }
            else if (randomEnemy < 21)
            {
                enemy = new Enemy(EnemyClass.EvilWitch);
            }
            else if (randomEnemy < 41)
            {
                enemy = new Enemy(EnemyClass.GiantSpider);
            }
            else if (randomEnemy < 71)
            {
                enemy = new Enemy(EnemyClass.Skeleton);
            }
            else if (randomEnemy < 101)
            {
                enemy = new Enemy(EnemyClass.Rat);
            }

            Console.WriteLine($"You have encountered {enemy.Class}.");

            return enemy;
        }
    }
}
