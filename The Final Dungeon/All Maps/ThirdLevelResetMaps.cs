using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMaps
{
    public class ThirdLevelResetMaps
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

        public static char[][] BossMap =
            {
                "                                 ".ToCharArray(),
                "                                 ".ToCharArray(),
                "         :~~~~~~~~~~~~~:         ".ToCharArray(),
                "         :.............:         ".ToCharArray(),
                "         :.............:         ".ToCharArray(),
                "         :.............:         ".ToCharArray(),
                "         :.............:         ".ToCharArray(),
                "         :.............:         ".ToCharArray(),
                "         :~~~~~~~~~~~~~:         ".ToCharArray(),
                "                                 ".ToCharArray(),
                "                                 ".ToCharArray(),
            };

        public static List<char[][]> LevelThreeResetMaps = new List<char[][]>()
            {
                FirstMap, SecondMap, ThirdMap, FourthMap, BossMap,
            };
    }
}
