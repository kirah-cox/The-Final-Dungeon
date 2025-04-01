using AllCreations;
using System.Reflection.Emit;

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
            if (player.Health == 13 && player.Level == 2)
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
            if (player.Health == 19 && player.Level == 4)
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
    }
}