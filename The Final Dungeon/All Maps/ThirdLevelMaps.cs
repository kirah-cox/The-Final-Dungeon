using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMaps
{
    public class ThirdLevelMaps
    {
        public static char[][] FirstMap =
            {
                "                   :~~0~~~~~~~~~:".ToCharArray(),
                "                   :............:".ToCharArray(),
                "                   :............:".ToCharArray(),
                "                   :............:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~:............:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            };
        public static bool FirstChestEmpty { get; set; } = false;

        public static char[][] SecondMap =
        {
                ":~~~~~~0~~~:                     ".ToCharArray(),
                ":..........:                     ".ToCharArray(),
                ":..........:                     ".ToCharArray(),
                ":..........:~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~:..........:".ToCharArray(),
                "                     :..........:".ToCharArray(),
                "                     :..........:".ToCharArray(),
                "                     :~~~O~~~~~~:".ToCharArray(),
            };

        public static bool SecondChestEmpty { get; set; } = false;

        public static char[][] ThirdMap =
        {
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................0".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...........:~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
                ":...........:                    ".ToCharArray(),
                ":...........:                    ".ToCharArray(),
                ":...........:                    ".ToCharArray(),
                ":~~~~~O~~~~~:                    ".ToCharArray(),
            };
        public static bool ThirdChestEmpty { get; set; } = false;

        public static char[][] FourthMap =
        {
                "              :~~~~~~~B~~:       ".ToCharArray(),
                "              :..........:       ".ToCharArray(),
                "              :..........:       ".ToCharArray(),
                "              :..........:       ".ToCharArray(),
                "              :..........:       ".ToCharArray(),
                ":~~~~~~~~~~~~~:..........:       ".ToCharArray(),
                ":........................:       ".ToCharArray(),
                ":........................:       ".ToCharArray(),
                "O........................:       ".ToCharArray(),
                ":........................:       ".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~~~~:       ".ToCharArray(),
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

        public static List<char[][]> LevelThreeMaps = new List<char[][]>()
            {
                FirstMap, SecondMap, ThirdMap, FourthMap, BossMap,
            };

        public static List<bool> LevelThreeChests = new List<bool>()
            {
                FirstChestEmpty, SecondChestEmpty, ThirdChestEmpty, FourthChestEmpty, BossChestEmpty,
            };

        public static List<int> LevelThreeUpDown = new List<int>()
            {
                5, 1, 9, 1, 9, 3, 8, 1, 7
            };

        public static List<int> LevelThreeLeftRight = new List<int>()
            {
                1, 22, 25, 7, 6, 31, 1, 22, 16
            };
    }
}
