﻿using System;
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
                ":iX...i..iiii:.....ii:iiiiiiii~~:".ToCharArray(),
                ":.ii..ii...ii:......i:iiiiiiiiii:".ToCharArray(),
                ":.ii.................:~~iiKiiiii:".ToCharArray(),
                ":.i.......X...i......:~~~~~~~.~~:".ToCharArray(),
                ":..i.....i.....ii.X............X:".ToCharArray(),
                ":ii........:~~~~~~~~~:....:~~~~~:".ToCharArray(),
                ":s.........:         :X.......ii:".ToCharArray(),
                ":~~~:....i.:         :~~:......i:".ToCharArray(),
                ":.....iXiii:         :m.........:".ToCharArray(),
                ":~~~~~~~~~~:         :~~~~~~~#~~:".ToCharArray(),
            };
        public static bool FirstChestEmpty { get; set; } = false;

        public static char[][] SecondMap =
            {
                "                      :~~~~O~~~~:".ToCharArray(),
                "                      :ii.....X.:".ToCharArray(),
                "                      :.i.......:".ToCharArray(),
                "                      :i.......i:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~:........i:".ToCharArray(),
                ":..iiii........Xi...ii........ii:".ToCharArray(),
                ":...Xi.........i............:~~~:".ToCharArray(),
                "#..ii.........................ii:".ToCharArray(),
                ":i..........iii....X.i..ii...m..:".ToCharArray(),
                ":iii......iiX...i......iiiiX...X:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            };

        public static bool SecondChestEmpty { get; set; } = false;

        public static char[][] ThirdMap =
            {
                "                                 ".ToCharArray(),
                "                                 ".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
                ":........ii..i...i.........iii.X:".ToCharArray(),
                ":X..........ii.i.i...........i..:".ToCharArray(),
                "#..ii........i.iMiXii...........O".ToCharArray(),
                ":...iiii..i..i.iiiii.........X..:".ToCharArray(),
                ":.iiiXm.ii....X.......i.ii......:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
                "                                 ".ToCharArray(),
                "                                 ".ToCharArray(),
            };
        public static bool ThirdChestEmpty { get; set; } = false;

        public static char[][] FourthMap =
        {
                ":~~~B~~~~~~~~~~~~~:              ".ToCharArray(),
                ":iiiiiiiiiiiiiiiii:              ".ToCharArray(),
                ":iiiiiiiiiiiiiiiii:              ".ToCharArray(),
                ":iiiiiiiiiiiiiiiii:              ".ToCharArray(),
                ":iii....iiiiiii...:              ".ToCharArray(),
                ":..........iii....:              ".ToCharArray(),
                ":.................:~~~~~~~~~~~~~:".ToCharArray(),
                ":ii......iii......iiiii.........:".ToCharArray(),
                ":mii...............iii....i.....O".ToCharArray(),
                ":i......ii.....iiiiiii.....ii...:".ToCharArray(),
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
