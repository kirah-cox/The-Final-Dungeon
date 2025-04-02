using System.Text;
using AllMaps;
using AllCreations;
using MyTools;

public class Program
{
    public static void Main()
    {
        string character = "@";

        Map map = new Map();

        StringBuilder sb = new StringBuilder();

        Player player = new Player(Tools.MenuScreen());

        Console.Clear();

        while (!Tools.EncounteredEnemy)
        {
            Tools.DrawMainMap(sb, map, map.FirstMap, character);

            Tools.Move(map, map.FirstMap);
            
            Tools.DrawMainMap(sb, map, map.FirstMap, character);

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

