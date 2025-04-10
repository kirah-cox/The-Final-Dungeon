using System.Text;
using AllMaps;
using AllCreations;
using MyTools;
using LootThings;
using AllProjectiles;

public class Program
{
    public static async Task Main()
    {
        Character character = new Character("@");

        StringBuilder sb = new StringBuilder();

        Player player = new Player(MainDrawingMap.MenuScreen());

        Projectile projectile1 = new Projectile("*");

        Console.Clear();

        while (!Tools.EncounteredEnemy)
        {

            if (Tools.BossFight)
            {
                projectile1.CreateProjectile(sb, FirstLevelMaps.LevelOneMaps[Tools.MapNumber]);
            }

            var drawMap = Task.Run(() => MainDrawingMap.DrawMainMap(sb, FirstLevelMaps.LevelOneMaps[Tools.MapNumber], FirstLevelResetMaps.LevelOneResetMaps[Tools.MapNumber], character, projectile1));
            
            await MainMove.Move(player, FirstLevelMaps.LevelOneMaps[Tools.MapNumber], sb, character);

            await drawMap;

            while (Tools.EncounteredEnemy)
            {
                Enemy enemy = Enemy.EnemyEncounter();

                MainBattle.Battle(player, enemy);

                Tools.EncounteredEnemy = false;
            }

            player.LevelUp();
        }
    }
}

