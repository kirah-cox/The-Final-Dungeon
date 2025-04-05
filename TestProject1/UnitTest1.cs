using AllCreations;
using System.Reflection.Emit;
using LootThings;

namespace TestProject1
{
    public class Tests
    {
        

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            Player player = new Player(PlayerClass.Warrior);
            var key = ConsoleKey.D1;
            player.Experience = 25;
            ModifiedMethods.LevelUp(key, player);
            if (player.Health == 28 && player.Level == 2)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test2()
        {
            Player player = new Player(PlayerClass.Warrior);
            player.Experience = 75;
            var key = ConsoleKey.D1;
            ModifiedMethods.LevelUp(key, player);
            ModifiedMethods.LevelUp(key, player);
            ModifiedMethods.LevelUp(key, player);
            if (player.Health == 34 && player.Level == 4)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test3()
        {
            Player player = new Player(PlayerClass.Warrior);
            player.Experience = 25;
            var key = ConsoleKey.D1;
            ModifiedMethods.LevelUp(key, player);
            if (player.Strength == 6)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test4()
        {
            Player player = new Player(PlayerClass.Wizard);
            player.Experience = 25;
            var key = ConsoleKey.D2;
            ModifiedMethods.LevelUp(key, player);
            if (player.Mana == 6)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test5()
        {
            Player player = new Player(PlayerClass.Rogue);
            player.Experience = 25;
            var key = ConsoleKey.D3;
            ModifiedMethods.LevelUp(key, player);
            if (player.Luck == 6)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        public void Test6()
        {
            Player player = new Player(PlayerClass.Warrior);
            player.Experience = 25;
            var key = ConsoleKey.D2;
            ModifiedMethods.LevelUp(key, player);
            if (player.Mana == 2)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test7()
        {
            Player player = new Player(PlayerClass.Wizard);
            player.Experience = 25;
            var key = ConsoleKey.D3;
            ModifiedMethods.LevelUp(key, player);
            if (player.Luck == 2)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test8()
        {
            Player player = new Player(PlayerClass.Rogue);
            player.Experience = 25;
            var key = ConsoleKey.D1;
            ModifiedMethods.LevelUp(key, player);
            if (player.Strength == 2)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test9()
        {
            Player player = new Player(PlayerClass.Rogue);
            player.Level = 4;
            player.Experience = 105;
            player.CalculateExperience();
            if (player.ReadyToLevelUp == true)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test10()
        {
            Player player = new Player(PlayerClass.Rogue);
            player.Level = 4;
            player.Experience = 95;
            player.CalculateExperience();
            if (player.ReadyToLevelUp == false)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test11()
        {
            Player player = new Player(PlayerClass.Rogue);
            var key = ConsoleKey.D1;
            player.Experience = 30;
            ModifiedMethods.LevelUp(key, player);
            if (player.Level == 2)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test12()
        {
            Player player = new Player(PlayerClass.Rogue);
            var key = ConsoleKey.D1;
            player.Level = 1;
            player.Experience = 20;
            ModifiedMethods.LevelUp(key, player);
            if (player.Level == 1)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test13()
        {
            Player player = new Player(PlayerClass.Warrior);
            if (ModifiedMethods.Attack(player, 1) == 6 || ModifiedMethods.Attack(player, 1) == 12)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test14()
        {
            Player player = new Player(PlayerClass.Warrior);
            player.Luck = 1;
            if (ModifiedMethods.Attack(player, 2) == 12)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test15()
        {
            Player player = new Player(PlayerClass.Warrior);
            player.Luck = 3;
            if (ModifiedMethods.Attack(player, 4) == 12)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test16()
        {
            Player player = new Player(PlayerClass.Warrior);
            player.Luck = 26;
            if (ModifiedMethods.Attack(player, 20) == 12)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test17()
        {
            Player player = new Player(PlayerClass.Warrior);
            player.Luck = 26;
            if (ModifiedMethods.Attack(player, 50) == 6)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test18()
        {
            Player player = new Player(PlayerClass.Warrior);
            player.Experience = 75;
            var key = ConsoleKey.D1;
            ModifiedMethods.LevelUp(key, player);
            ModifiedMethods.LevelUp(key, player);
            ModifiedMethods.LevelUp(key, player);
            if (ModifiedMethods.Attack(player, 2) == 18)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test19()
        {
            Player player = new Player(PlayerClass.Warrior);
            Enemy enemy = new Enemy(EnemyClass.Rat);
            player.TakeDamage(enemy.Attack());
            if (player.Health == 21 || player.Health == 17)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test20()
        {
            Player player = new Player(PlayerClass.Warrior);
            Enemy enemy = new Enemy(EnemyClass.Rat);
            enemy.TakeDamage(player.Attack());
            if (enemy.Health == 4 || enemy.Health == 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test21()
        {
            Player player = new Player(PlayerClass.Warrior);
            player.PotionInventory.Add(Potions.PotionType.Health, 1);
            player.Health = 5;
            ModifiedMethods.UsePotion(player, Potions.PotionType.Health);
            if (player.Health == 25)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test22()
        {
            Player player = new Player(PlayerClass.Warrior);
            player.PotionInventory.Add(Potions.PotionType.Health, 1);
            player.Level = 4;
            player.Health = 5;
            ModifiedMethods.UsePotion(player, Potions.PotionType.Health);
            if (player.Health == 30)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}