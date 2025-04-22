using System.Text;
using AllMaps;
using AllCreations;
using MyTools;
using LootThings;
using SavingAndLoading;

public class Program
{
    public static void Main()
    {
        Character character = new Character("@");

        StringBuilder sb = new StringBuilder();

        Player player;

        MainDrawingMap.MainMenuScreen(sb, character, out player);

        SaveLoad.Save(player);

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

                MainBattle.Battle(sb, player, enemy, character);

                Tools.EncounteredEnemy = false;

                if (Tools.Loading)
                {
                    SaveLoad.Load(sb, character, out player);
                    Tools.Loading = false;
                }
            }

            if (Tools.BossFight)
            {
                Enemy enemy = new Enemy(Tools.BossEnemies[Tools.LevelNumber]);

                MainBattle.Battle(sb, player, enemy, character);

                Tools.BossFight = false;

                Tools.BossDefeated = true;

                if (Tools.Loading)
                {
                    SaveLoad.Load(sb, character, out player);
                    Tools.Loading = false;
                }
            }

            player.LevelUp();
        }
    }
}

