using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMaps
{
    public class Map
    {
        public static char[][] FirstMap =
        {
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            ":              m                :".ToCharArray(),
            ":                               :".ToCharArray(),
            ":                               :".ToCharArray(),
            ":                               :".ToCharArray(),
            ":                               0".ToCharArray(),
            ":                               :".ToCharArray(),
            ":                               :".ToCharArray(),
            ":                               :".ToCharArray(),
            ":                               :".ToCharArray(),
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
        };
        public static bool FirstChestEmpty { get; set; } = false;

        public static char[][] SecondMap =
        {
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            ":                               :".ToCharArray(),
            "O                               :".ToCharArray(),
            ":                               :".ToCharArray(),
            ":~~~~~~~~~~~~~~~~:              :".ToCharArray(),
            "                 :              :".ToCharArray(),
            "                 :              :".ToCharArray(),
            "                 :              :".ToCharArray(),
            "                 :              :".ToCharArray(),
            "                 :             m:".ToCharArray(),
            "                 :~~~~~~0~~~~~~~:".ToCharArray(),
        };
        public static bool SecondChestEmpty { get; set; } = false;

        public static char[][] ThirdMap =
        {
            ":~~~~~~O~~~~~~~:                 ".ToCharArray(),
            ":              :                 ".ToCharArray(),
            ":              :                 ".ToCharArray(),
            ":              :                 ".ToCharArray(),
            ":              :~~~~~~~~~~~~~~~~:".ToCharArray(),
            ":                   m           :".ToCharArray(),
            ":                               :".ToCharArray(),
            ":                               :".ToCharArray(),
            ":                               0".ToCharArray(),
            ":                               :".ToCharArray(),
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
        };
        public static bool ThirdChestEmpty { get; set; } = false;

        public static char[][] FourthMap =
        {
            "         :~~~~~~~~~~~~~:         ".ToCharArray(),
            "         :             :         ".ToCharArray(),
            "         :             :         ".ToCharArray(),
            "         :             :         ".ToCharArray(),
            "         :             :         ".ToCharArray(),
            "         :             :         ".ToCharArray(),
            "         :             :         ".ToCharArray(),
            "         :             :         ".ToCharArray(),
            "         O             :         ".ToCharArray(),
            "         :             :         ".ToCharArray(),
            "         :~~~~~~~~~~~~~:         ".ToCharArray(),
        };
        public static bool FourthChestEmpty { get; set; } = false;

        public static List<char[][]> LevelOneMaps = new List<char[][]>()
        {
            FirstMap, SecondMap, ThirdMap, FourthMap
        };

        public static List<bool> LevelOneChests = new List<bool>()
        {
            FirstChestEmpty, SecondChestEmpty, ThirdChestEmpty, FourthChestEmpty,
        };

        public static List<int> LevelOneUpDown = new List<int>()
        {
            1, 5, 2, 9, 1, 8, 8,
        };

        public static List<int> LevelOneLeftRight= new List<int>()
        {
            1, 31, 1, 24, 7, 31, 10,
        };
    }
}
