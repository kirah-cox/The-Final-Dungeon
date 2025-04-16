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
            ":.  ...oo.... ......o..  .....R.:".ToCharArray(),
            "O.......o.......o...........o.. :".ToCharArray(),
            ":..o..................o. ...ooo.:".ToCharArray(),
            ":. ..o....oo.....  ..... .....o.:".ToCharArray(),
            ":..oo....   ... .......oo... ...:".ToCharArray(),
            ":~~~~~~~~~~~~~~~~:.  ..........o:".ToCharArray(),
            "                 :.........oo...:".ToCharArray(),
            "                 :..o.. ......o.:".ToCharArray(),
            "                 :oo.....o...oom:".ToCharArray(),
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
