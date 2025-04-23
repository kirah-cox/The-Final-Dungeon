using AllCreations;
using AllMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootThings;
using System.Security.Cryptography.X509Certificates;

namespace MyTools
{
    public class Tools
    {
        public static bool EncounteredEnemy { get; set; } = false;
        public static bool InBattle { get; set; } = false;
        public static bool ChestEmpty { get; set; } = false;
        public static bool ObtainedKey { get; set; } = false;
        public static bool CrossedGap { get; set; } = false;
        public static bool ObtainedFeather { get; set; } = false;
        public static bool ObtainedIceSkates { get; set; } = false;
        public static bool PushingBoulder { get; set; } = false;
        public static bool BoulderOverGap { get; set; } = false;
        public static Dictionary<int, int> BoulderOverButton { get; set; } = new Dictionary<int, int>();
        public static Dictionary<int, int> ButtonChange { get; set; } = new Dictionary<int, int>();
        public static bool ButtonHasChangedX { get; set ; } = false;
        public static bool ButtonHasChangedQ { get; set ; } = false;
        public static bool ResetRoom { get; set; } = false;
        public static int MapNumber { get; set; } = 1;
        public static int LevelNumber { get; set; } = 2;
        public static bool BossRoom { get; set; } = false;
        public static bool BossFight { get; set; } = false;
        public static bool BossDefeated { get; set; } = false;
        public static bool CrossingIce { get; set; } = false;
        public static int IceLineNumber { get; set; } = 1;
        public static bool IceHitSomething { get; set; } = false;
        public static bool KeepIce { get; set; } = false;
        public static bool Loading { get; set; } = false;

        public static void PressEnter()
        {
            Console.WriteLine("Press enter to continue.");

            bool enterPressed = false;
            while (!enterPressed)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    enterPressed = true;
                }
            }
        }

        public static List<List<char[][]>> LevelsList = new List<List<char[][]>>()
        {
            FirstLevelMaps.LevelOneMaps, SecondLevelMaps.LevelTwoMaps, ThirdLevelMaps.LevelThreeMaps,
        };

        public static List<List<char[][]>> ResetLevelsList = new List<List<char[][]>>()
        {
            FirstLevelResetMaps.LevelOneResetMaps, SecondLevelResetMaps.LevelTwoResetMaps, ThirdLevelResetMaps.LevelThreeResetMaps,
        };

        public static List<List<bool>> ChestList = new List<List<bool>>()
        {
            FirstLevelMaps.LevelOneChests, SecondLevelMaps.LevelTwoChests, ThirdLevelMaps.LevelThreeChests
        };

        public static List<List<int>> UpDownList = new List<List<int>>()
        {
            FirstLevelMaps.LevelOneUpDown, SecondLevelMaps.LevelTwoUpDown, ThirdLevelMaps.LevelThreeUpDown
        };

        public static List<List<int>> LeftRightList = new List<List<int>>()
        {
            FirstLevelMaps.LevelOneLeftRight, SecondLevelMaps.LevelTwoLeftRight, ThirdLevelMaps.LevelThreeLeftRight
        };

        public static List<EnemyClass> BossEnemies = new List<EnemyClass>()
        {
            EnemyClass.KingFrog, EnemyClass.GiantSpider, EnemyClass.DungeonKing
        };
    }
}


