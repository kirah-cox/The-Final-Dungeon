using System.Text;
using AllMaps;
using AllCreations;
using MyTools;
using LootThings;

public class Program
{
    public static void Main()
    {
        Character character = new Character("@");

        StringBuilder sb = new StringBuilder();

        Player player = new Player(MainDrawingMap.MenuScreen());

        Console.Clear();

        while (true)
        {
            MainDrawingMap.DrawMainMap(sb, Tools.LevelsList[Tools.LevelNumber][Tools.MapNumber], Tools.ResetLevelsList[Tools.LevelNumber][Tools.MapNumber], character);

            if (!Tools.InBattle)
            {
                MainMove.Move(player, Tools.LevelsList[Tools.LevelNumber][Tools.MapNumber], Tools.ResetLevelsList[Tools.LevelNumber][Tools.MapNumber], sb, character);
            }

            if (Tools.EncounteredEnemy)
            {
                Enemy enemy = Enemy.EnemyEncounter();

                MainBattle.Battle(player, enemy);

                Tools.EncounteredEnemy = false;
            }

            if (Tools.BossFight)
            {
                Enemy enemy = new Enemy(Tools.BossEnemies[Tools.LevelNumber]);

                MainBattle.Battle(player, enemy);

                Tools.BossFight = false;

                Tools.BossDefeated = true;
            }

            player.LevelUp();
        }
    }
}

