using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMaps
{
    public class SecondLevelResetMaps
    {
        public static char[][] FirstMap =
            {
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
                ":..i..i..i...........:iiiiiiii~~:".ToCharArray(),
                ":..i..i..............:iiiiiiiiii:".ToCharArray(),
                ":..i.................:~~iiKiiiii:".ToCharArray(),
                ":....................:~~~~~~~.~~:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":ii........:~~~~~~~~~:.~~.......:".ToCharArray(),
                ":........ii:         :ii:.......:".ToCharArray(),
                ":..........:         :ii:.......:".ToCharArray(),
                ":..........:         :ii:.......:".ToCharArray(),
                ":~~~~~~~~~~:         :~~~~~~~#~~:".ToCharArray(),
            };

        public static char[][] SecondMap =
            {
                "                      :~~~~O~~~~:".ToCharArray(),
                "                      :.........:".ToCharArray(),
                "                      :.........:".ToCharArray(),
                "                      :.........:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~:.........:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                "#...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            };

        public static char[][] ThirdMap =
        {
                "                                 ".ToCharArray(),
                "                                 ".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                "#...............................O".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":...............................:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
                "                                 ".ToCharArray(),
                "                                 ".ToCharArray(),
            };

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

        public static char[][] BossMap =
            {
                "                                 ".ToCharArray(),
                "                                 ".ToCharArray(),
                "         :~~~~~~~~~~~~~:         ".ToCharArray(),
                "         :.............:         ".ToCharArray(),
                "         :.............:         ".ToCharArray(),
                "         :......z......:         ".ToCharArray(),
                "         :.............:         ".ToCharArray(),
                "         :.............:         ".ToCharArray(),
                "         :~~~~~~~~~~~~~:         ".ToCharArray(),
                "                                 ".ToCharArray(),
                "                                 ".ToCharArray(),
            };

        public static List<char[][]> LevelTwoResetMaps = new List<char[][]>()
            {
                FirstMap, SecondMap, ThirdMap, FourthMap, BossMap,
            };
    }
}
