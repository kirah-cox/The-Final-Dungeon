using System.Text;
using AllMaps;
using AllCreations;
using MyTools;
using LootThings;

public class Program
{
    public static void Main()
    {
        string character = "@";

        StringBuilder sb = new StringBuilder();

        Player player = new Player(MainDrawingMap.MenuScreen());

        Console.Clear();

        while (!Tools.EncounteredEnemy)
        {
            MainDrawingMap.DrawMainMap(sb, Map.LevelOneMaps[Tools.MapNumber], character);

            MainMove.Move(player, Map.LevelOneMaps[Tools.MapNumber], sb, character);
            
            while (Tools.EncounteredEnemy)
            {
                Enemy enemy = Enemy.EnemyEncounter();

                Tools.Battle(player, enemy);

                Tools.EncounteredEnemy = false;
            }

            player.LevelUp();
        }
    }
}

