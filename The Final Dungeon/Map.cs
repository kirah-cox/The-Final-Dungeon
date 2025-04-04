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

        public char[][] OtherMap =
        {
            "|-------------------------------|".ToCharArray(),
            "|                               |".ToCharArray(),
            "|                               |".ToCharArray(),
            "|                               |".ToCharArray(),
            "|                               |".ToCharArray(),
            "|                               |".ToCharArray(),
            "|                               |".ToCharArray(),
            "|                               |".ToCharArray(),
            "|                               |".ToCharArray(),
            "|                               |".ToCharArray(),
            "|-------------------------------|".ToCharArray(),
        };

        public static List<char[][]> LevelOneMaps = new List<char[][]>()
        {
            FirstMap, SecondMap,
        };

        public static List<bool> LevelOneChests = new List<bool>()
        {
            FirstChestEmpty, SecondChestEmpty,
        };
    }
}
