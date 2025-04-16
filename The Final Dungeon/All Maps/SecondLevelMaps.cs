using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMaps
{
    public class SecondLevelMaps
    {
        public static char[][] FirstMap =
            {
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":.....ii...:~~~~~~~~~:..........:".ToCharArray(),
                ":.....ii...:         :..........:".ToCharArray(),
                ":.....ii...:         :..........:".ToCharArray(),
                ":.....ii...:         :..........:".ToCharArray(),
                ":..........:         :..........:".ToCharArray(),
                ":~~~~~~~~~~:         :~~~~~~~0~~:".ToCharArray(),
            };
        public static bool FirstChestEmpty { get; set; } = false;

        public static char[][] SecondMap =
        {
                "                      :~~~~O~~~~:".ToCharArray(),
                "                      :.........:".ToCharArray(),
                "                      :.........:".ToCharArray(),
                "                      :.........:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~:.........:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                "0...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            };

        public static bool SecondChestEmpty { get; set; } = false;

        public static char[][] ThirdMap =
        {
                "                                 ".ToCharArray(),
                "                                 ".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                "0...............................O".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
                "                                 ".ToCharArray(),
                "                                 ".ToCharArray(),
            };
        public static bool ThirdChestEmpty { get; set; } = false;

        public static char[][] FourthMap =
        {
                ":~~~B~~~~~~~~~~~~~:              ".ToCharArray(),
                ":.................:              ".ToCharArray(),
                ":.................:              ".ToCharArray(),
                ":.................:              ".ToCharArray(),
                ":.................:              ".ToCharArray(),
                ":.................:              ".ToCharArray(),
                ":.................:~~~~~~~~~~~~~:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................O".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            };
        public static bool FourthChestEmpty { get; set; } = false;

        public static char[][] BossMap =
            {
                "                                 ".ToCharArray(),
                "                                 ".ToCharArray(),
                "         :~~~~~~~~~~~~~:         ".ToCharArray(),
                "         :.............:         ".ToCharArray(),
                "         :.............:         ".ToCharArray(),
                "         :......F......:         ".ToCharArray(),
                "         :.............:         ".ToCharArray(),
                "         :.............:         ".ToCharArray(),
                "         :~~~~~~~~~~~~~:         ".ToCharArray(),
                "                                 ".ToCharArray(),
                "                                 ".ToCharArray(),
            };

        public static bool BossChestEmpty { get; set; } = false;

        public static List<char[][]> LevelTwoMaps = new List<char[][]>()
            {
                FirstMap, SecondMap, ThirdMap, FourthMap, BossMap,
            };

        public static List<bool> LevelTwoChests = new List<bool>()
            {
                FirstChestEmpty, SecondChestEmpty, ThirdChestEmpty, FourthChestEmpty, BossChestEmpty,
            };

        public static List<int> LevelTwoUpDown = new List<int>()
            {
                9, 9, 1, 7, 5, 5, 8, 1, 7
            };

        public static List<int> LevelTwoLeftRight = new List<int>()
            {
                1, 29, 27, 1, 31, 1, 31, 4, 16
            };
    }
}
