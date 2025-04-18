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
            ":.............omo.....x......R.o:".ToCharArray(),
            ":......oo......o... ....   .....:".ToCharArray(),
            ":s...ooooox......... .....o.....:".ToCharArray(),
            ":            ...................:".ToCharArray(),
            ":oooooo.o..  o..................#".ToCharArray(),
            ":oo...oo.o. o..............x....:".ToCharArray(),
            ":K...o.o.o. ....o......o.......o:".ToCharArray(),
            ":o....oo.o. .o..........o.....oo:".ToCharArray(),
            ":oooooo.o.. ooo...x...  ......oo:".ToCharArray(),
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
        };

        public static char[][] SecondMap =
        {
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            ":.  ...oo..x. ......o..  .....R.:".ToCharArray(),
            "O.......o.......o...........o.. :".ToCharArray(),
            ":..o.................xo. ...ooo.:".ToCharArray(),
            ":. ..o....oo.....  ..... ..x..o.:".ToCharArray(),
            ":x.oo....   ... .......oo... ...:".ToCharArray(),
            ":~~~~~~~~~~~~~~~~:x  ..........o:".ToCharArray(),
            "                 :.........oo...:".ToCharArray(),
            "                 :..o.. ......o.:".ToCharArray(),
            "                 :oo.x...o...oom:".ToCharArray(),
            "                 :~~~~~~#~~~~~~~:".ToCharArray(),
        };

        public static char[][] ThirdMap =
        {
            ":~~~O~~~:                        ".ToCharArray(),
            ":.......:                        ".ToCharArray(),
            ":.......:                        ".ToCharArray(),
            ":......o:                        ".ToCharArray(),
            ":.......:~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            ": .......oo..x.....R.....o.o...x:".ToCharArray(),
            ":  ......o.... .........o.oo....:".ToCharArray(),
            ":............ ...........oo..M..#".ToCharArray(),
            ":x..oo..........o.......o.oo....:".ToCharArray(),
            ":.oom.o.......o..........o.o....:".ToCharArray(),
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
        };

        public static char[][] FourthMap =
        {
            "         :~~~~~~B~~~~~~:         ".ToCharArray(),
            "         :oo.......oo..:         ".ToCharArray(),
            "         :o............:         ".ToCharArray(),
            "         :             :         ".ToCharArray(),
            "         :............o:         ".ToCharArray(),
            "         :             :         ".ToCharArray(),
            "         :oo...........:         ".ToCharArray(),
            "         :....o........:         ".ToCharArray(),
            "         O...........oo:         ".ToCharArray(),
            "         :o.........o..:         ".ToCharArray(),
            "         :~~~~~~~~~~~~~:         ".ToCharArray(),
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

        public static List<char[][]> LevelOneResetMaps = new List<char[][]>()
        {
            FirstMap, SecondMap, ThirdMap, FourthMap, BossMap
        };
    }
}
