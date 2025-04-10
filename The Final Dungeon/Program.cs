using System.Text;
using AllMaps;
using AllCreations;
using MyTools;
using LootThings;
using AllProjectiles;

public class Program
{
    public static void Main()
    {
        Character character = new Character("@");

        StringBuilder sb = new StringBuilder();

        Player player = new Player(MainDrawingMap.MenuScreen());

        Console.Clear();

        while (!Tools.EncounteredEnemy)
        {
            MainDrawingMap.DrawMainMap(sb, FirstLevelMaps.LevelOneMaps[Tools.MapNumber], FirstLevelResetMaps.LevelOneResetMaps[Tools.MapNumber], character);

            MainMove.Move(player, FirstLevelMaps.LevelOneMaps[Tools.MapNumber], sb, character);
            
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

