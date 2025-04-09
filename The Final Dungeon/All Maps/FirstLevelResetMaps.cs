using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMaps
{
    class FirstLevelResetMaps
    {
        public static char[][] FirstMap =
        {
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            ":.............omo............R.o:".ToCharArray(),
            ":......oo......o... ....   .....:".ToCharArray(),
            ":....ooooo.......... .....o.....:".ToCharArray(),
            ":            ...................:".ToCharArray(),
            ":oooooo.o..  o..................0".ToCharArray(),
            ":oo...oo.o. o...................:".ToCharArray(),
            ":K...o.o.o. ....o......o.......o:".ToCharArray(),
            ":o....oo.o. .o..........o.....oo:".ToCharArray(),
            ":oooooo.o.. ooo.......  ......oo:".ToCharArray(),
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
        };

        public static char[][] SecondMap =
        {
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            ":.............................R.:".ToCharArray(),
            "O...............................:".ToCharArray(),
            ":...............................:".ToCharArray(),
            ":~~~~~~~~~~~~~~~~:..............:".ToCharArray(),
            "                 :..............:".ToCharArray(),
            "                 :..............:".ToCharArray(),
            "                 :..............:".ToCharArray(),
            "                 :..............:".ToCharArray(),
            "                 :.............m:".ToCharArray(),
            "                 :~~~~~~0~~~~~~~:".ToCharArray(),
        };

        public static char[][] ThirdMap =
        {
            ":~~~O~~~:                        ".ToCharArray(),
            ":.......:                        ".ToCharArray(),
            ":.......:                        ".ToCharArray(),
            ":......o:                        ".ToCharArray(),
            ":.......:~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            ": .......oo........R.....o.o....:".ToCharArray(),
            ":  ......o.... .........o.oo....:".ToCharArray(),
            ":............ ...........oo..M..0".ToCharArray(),
            ":...oo..........o.......o.oo....:".ToCharArray(),
            ":.oom.o.......o..........o.o....:".ToCharArray(),
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
        };

        public static char[][] FourthMap =
        {
            "         :~~~~~~~~~~~~~:         ".ToCharArray(),
            "         :.............:         ".ToCharArray(),
            "         :             :         ".ToCharArray(),
            "         :.............:         ".ToCharArray(),
            "         :             :         ".ToCharArray(),
            "         :.............:         ".ToCharArray(),
            "         :.............:         ".ToCharArray(),
            "         :.............:         ".ToCharArray(),
            "         O.............:         ".ToCharArray(),
            "         :.............:         ".ToCharArray(),
            "         :~~~~~~~~~~~~~:         ".ToCharArray(),
        };

        public static char[][] BossMap =
        {
            ":                 _'^'_                 :".ToCharArray(),
            ":                (0'-'0)                :".ToCharArray(),
            ":             _ (   -   ) _             :".ToCharArray(),
            ":           (  )(       )(  )           :".ToCharArray(),
            ":            ( ) ) | | ( ( )            :".ToCharArray(),
            ":           oO)  oO) (Oo  (Oo           :".ToCharArray(),
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            ":.......................................:".ToCharArray(),
            ":.......................................:".ToCharArray(),
            ":.......................................:".ToCharArray(),
            ":.......................................:".ToCharArray(),
            ":.......................................:".ToCharArray(),
            ":.......................................:".ToCharArray(),
            ":.......................................:".ToCharArray(),
            ":.......................................:".ToCharArray(),
            ":.......................................:".ToCharArray(),
            ":.......................................:".ToCharArray(),
            ":.......................................:".ToCharArray(),
            ":.......................................:".ToCharArray(),
            ":.......................................:".ToCharArray(),
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
        };

        public static List<char[][]> LevelOneResetMaps = new List<char[][]>()
        {
            FirstMap, SecondMap, ThirdMap, FourthMap, BossMap
        };
    }
}
