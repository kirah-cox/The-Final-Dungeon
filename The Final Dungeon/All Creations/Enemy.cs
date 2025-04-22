using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using LootThings;
using MyTools;
using AllMaps;

namespace AllCreations
{
    public class Enemy : Creations
    {
        public EnemyClass Class { get; set; }
        public Random RandomExperience { get; set; } = new Random();
        public Random WeaponNumber { get; set; } = new Random();
        public Random RandomDropWeapon { get; set; } = new Random();
        public bool DropWeapon { get; set; } = false;
        public char[][] CombatBox { get; set; }

        public Enemy(EnemyClass enemyClass)
        {
            switch (enemyClass)
            {
                case EnemyClass.Spider: ConstructSpider();
                    break;
                case EnemyClass.Viper: ConstructViper();
                    break;
                case EnemyClass.Frog: ConstructFrog();
                    break;
                case EnemyClass.Rat: ConstructRat();
                    break;
                case EnemyClass.Slime: ConstructSlime();
                    break;
                case EnemyClass.Imp: ConstructImp();
                    break;
                case EnemyClass.Goblin: ConstructGoblin();
                    break;
                case EnemyClass.Kobold: ConstructKobold();
                    break;
                case EnemyClass.Skeleton: ConstructSkeleton();
                    break;
                case EnemyClass.Witch: ConstructWitch();
                    break;
                case EnemyClass.BoneWarrior: ConstructBoneWarrior();
                    break;
                case EnemyClass.Vampire: ConstructVampire();
                    break;
                case EnemyClass.Orc: ConstructOrc();
                    break;
                case EnemyClass.EvilEnt: ConstructEvilEnt();
                    break;
                case EnemyClass.Warlock: ConstructWarlock();
                    break;
                case EnemyClass.KingFrog:
                    Class = EnemyClass.KingFrog;
                    Health = 1;
                    Strength = 6;
                    Mana = 6;
                    Luck = 12;
                    Experience = 20;
                    CombatBox = CombatBoxes.FirstLevelBossCombatBox;
                    break;
                case EnemyClass.GiantSpider:
                    Class = EnemyClass.GiantSpider;
                    Health = 1;
                    Strength = 12;
                    Mana = 12;
                    Luck = 18;
                    Experience = 20;
                    CombatBox = CombatBoxes.SecondLevelBossCombatBox;
                    break;
                case EnemyClass.DungeonKing:
                    Class = EnemyClass.DungeonKing;
                    Health = 1;
                    Strength = 18;
                    Mana = 18;
                    Luck = 24;
                    Experience = 20;
                    CombatBox = CombatBoxes.ThirdLevelBossCombatBox;
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
            CombatBox = CombatBoxes.FirstLevelSpiderCombatBox;
            Experience = RandomExperience.Next(5, 8);
            Weapon = new SpiderWeapon(WeaponNumber.Next(1, 4));
            if(RandomDropWeapon.Next(1, 101) <= 50)
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
            CombatBox = CombatBoxes.FirstLevelViperCombatBox;
            Experience = RandomExperience.Next(12, 16);
            Weapon = new ViperWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 50)
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
            CombatBox = CombatBoxes.FirstLevelFrogCombatBox;
            Experience = RandomExperience.Next(3, 6);
            Weapon = new FrogWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 50)
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
            CombatBox = CombatBoxes.FirstLevelRatCombatBox;
            Experience = RandomExperience.Next(3, 6);
            Weapon = new RatWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 50)
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
            CombatBox = CombatBoxes.FirstLevelSlimeCombatBox;
            Experience = RandomExperience.Next(8, 12);
            Weapon = new SlimeWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 50)
            {
                DropWeapon = true;
            }
        }

        public void ConstructGoblin()
        {
            Health = 12;
            Class = EnemyClass.Goblin;
            Strength = 6;
            Mana = 1;
            Luck = 2;
            CombatBox = CombatBoxes.SecondLevelGoblinCombatBox;
            Experience = RandomExperience.Next(5, 8);
            Weapon = new GoblinWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 50)
            {
                DropWeapon = true;
            }
        }

        public void ConstructImp()
        {
            Health = 10;
            Class = EnemyClass.Imp;
            Strength = 3;
            Mana = 5;
            Luck = 6;
            CombatBox = CombatBoxes.SecondLevelImpCombatBox;
            Experience = RandomExperience.Next(3, 6);
            Weapon = new ImpWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 50)
            {
                DropWeapon = true;
            }
        }

        public void ConstructKobold()
        {
            Health = 15;
            Class = EnemyClass.Kobold;
            Strength = 7;
            Mana = 1;
            Luck = 5;
            CombatBox = CombatBoxes.SecondLevelKoboldCombatBox;
            Experience = RandomExperience.Next(8, 12);
            Weapon = new KoboldWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 50)
            {
                DropWeapon = true;
            }
        }

        public void ConstructSkeleton()
        {
            Health = 18;
            Class = EnemyClass.Skeleton;
            Strength = 8;
            Mana = 2;
            Luck = 15;
            CombatBox = CombatBoxes.SecondLevelSkeletonCombatBox;
            Experience = RandomExperience.Next(12, 15);
            Weapon = new SkeletonWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 50)
            {
                DropWeapon = true;
            }
        }

        public void ConstructWitch()
        {
            Health = 20;
            Class = EnemyClass.Witch;
            Strength = 1;
            Mana = 10;
            Luck = 20;
            CombatBox = CombatBoxes.SecondLevelWitchCombatBox;
            Experience = RandomExperience.Next(14, 18);
            Weapon = new WitchWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 50)
            {
                DropWeapon = true;
            }
        }

        public void ConstructBoneWarrior()
        {
            Health = 20;
            Class = EnemyClass.BoneWarrior;
            Strength = 10;
            Mana = 1;
            Luck = 15;
            CombatBox = CombatBoxes.ThirdLevelBoneWarriorCombatBox;
            Experience = RandomExperience.Next(3, 6);
            Weapon = new BoneWarriorWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 50)
            {
                DropWeapon = true;
            }
        }

        public void ConstructVampire()
        {
            Health = 23;
            Class = EnemyClass.Vampire;
            Strength = 5;
            Mana = 8;
            Luck = 25;
            CombatBox = CombatBoxes.ThirdLevelVampireCombatBox;
            Experience = RandomExperience.Next(5, 8);
            Weapon = new VampireWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 50)
            {
                DropWeapon = true;
            }
        }

        public void ConstructOrc()
        {
            Health = 25;
            Class = EnemyClass.Orc;
            Strength = 14;
            Mana = 1;
            Luck = 5;
            CombatBox = CombatBoxes.ThirdLevelOrcCombatBox;
            Experience = RandomExperience.Next(8, 12);
            Weapon = new OrcWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 50)
            {
                DropWeapon = true;
            }
        }

        public void ConstructEvilEnt()
        {
            Health = 27;
            Class = EnemyClass.EvilEnt;
            Strength = 7;
            Mana = 10;
            Luck = 20;
            CombatBox = CombatBoxes.ThirdLevelEvilEntCombatBox;
            Experience = RandomExperience.Next(12, 15);
            Weapon = new EvilEntWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 50)
            {
                DropWeapon = true;
            }
        }

        public void ConstructWarlock()
        {
            Health = 30;
            Class = EnemyClass.Warlock;
            Strength = 1;
            Mana = 20;
            Luck = 15;
            CombatBox = CombatBoxes.ThirdLevelWarlockCombatBox;
            Experience = RandomExperience.Next(14, 18);
            Weapon = new WarlockWeapon(WeaponNumber.Next(1, 4));
            if (RandomDropWeapon.Next(1, 101) <= 50)
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

            if (Tools.LevelNumber == 0)
            {
                if (randomEnemy < 11)
                {
                    enemy = new Enemy(EnemyClass.Viper);
                }
                else if (randomEnemy < 26)
                {
                    enemy = new Enemy(EnemyClass.Spider);
                }
                else if (randomEnemy < 46)
                {
                    enemy = new Enemy(EnemyClass.Slime);
                }
                else if (randomEnemy < 71)
                {
                    enemy = new Enemy(EnemyClass.Rat);
                }
                else if (randomEnemy < 101)
                {
                    enemy = new Enemy(EnemyClass.Frog);
                }
                return enemy;
            }
            else if (Tools.LevelNumber == 1)
            {
                if (randomEnemy < 11)
                {
                    enemy = new Enemy(EnemyClass.Witch);
                }
                else if (randomEnemy < 26)
                {
                    enemy = new Enemy(EnemyClass.Skeleton);
                }
                else if (randomEnemy < 46)
                {
                    enemy = new Enemy(EnemyClass.Kobold);
                }
                else if (randomEnemy < 71)
                {
                    enemy = new Enemy(EnemyClass.Goblin);
                }
                else if (randomEnemy < 101)
                {
                    enemy = new Enemy(EnemyClass.Imp);
                }
                return enemy;
            }
            else
            {
                if (randomEnemy < 11)
                {
                    enemy = new Enemy(EnemyClass.Warlock);
                }
                else if (randomEnemy < 26)
                {
                    enemy = new Enemy(EnemyClass.EvilEnt);
                }
                else if (randomEnemy < 46)
                {
                    enemy = new Enemy(EnemyClass.Vampire);
                }
                else if (randomEnemy < 71)
                {
                    enemy = new Enemy(EnemyClass.Orc);
                }
                else if (randomEnemy < 101)
                {
                    enemy = new Enemy(EnemyClass.BoneWarrior);
                }
                return enemy;
            }
        }
    }
}
