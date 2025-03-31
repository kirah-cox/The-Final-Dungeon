using AllCreations;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Player player;
            player = new Player(PlayerClass.Warrior);
        }

        [Test]
        public void Test1()
        {
            Player player = new Player(PlayerClass.Warrior);
            player.LevelUp();
            if (player.Health == 13 && player.Level == 2)
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