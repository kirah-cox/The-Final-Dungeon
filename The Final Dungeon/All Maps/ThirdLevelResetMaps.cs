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
                "                   :~~#~~~~~~~~~:".ToCharArray(),
                "                   :x........  .:".ToCharArray(),
                "                   :.. .......oo:".ToCharArray(),
                "                   : o.....  .o.:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~:   ...... ..:".ToCharArray(),
                ":.xoR.. oo .......oo  .....o....:".ToCharArray(),
                ":.o.... .  ..  ...... ......o..o:".ToCharArray(),
                ":...... o. .......... ..o.....oo:".ToCharArray(),
                ":...o.. ..   .....oo  .oox..o.oo:".ToCharArray(),
                ":x.oo   .. .....oo.mo.  .oxo...x:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            };

        public static char[][] SecondMap =
        {
                ":~~~~~~#~~~:                     ".ToCharArray(),
                ":X.......ii:                     ".ToCharArray(),
                ":iiiiiiiiii:                     ".ToCharArray(),
                ":.......iii:~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
                ":.~~~~~~:.......iXiii....i....iX:".ToCharArray(),
                ":iiiiiii:....X...ii.......i..Xii:".ToCharArray(),
                ":~~:Xiii:.....iii....ii........i:".ToCharArray(),
                ":~~~~~~~~~~~~~~~~~~~~:..X...:i..:".ToCharArray(),
                "                     :i.....:iii:".ToCharArray(),
                "                     :ii....:Xim:".ToCharArray(),
                "                     :~~~O~~~~~~:".ToCharArray(),
            };

        public static char[][] ThirdMap =
        {
                ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
                ":iXiiiiiii.i:.. ooR.oo.....oox.o:".ToCharArray(),
                ":i.iiiii.iii:.. o....x....oooo..:".ToCharArray(),
                ":iiiiiiiiiii:.. ............o...0".ToCharArray(),
                ":iiiiiKiiiii... ..o....o......o.:".ToCharArray(),
                ":iii.iXiiiii:.. .ooox.......oo.x:".ToCharArray(),
                ":iiiXiiiXiii:~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
                ":i.iiiiiiiXi:                    ".ToCharArray(),
                ":iiiiiiiiiii:                    ".ToCharArray(),
                ":...........:                    ".ToCharArray(),
                ":~~~~~O~~~~~:                    ".ToCharArray(),
            };

        public static char[][] FourthMap =
        {
                "              :~~~~~~~B~~:       ".ToCharArray(),
                "              :o.oo..iii.:       ".ToCharArray(),
                "              :ooo....ii.:       ".ToCharArray(),
                "              :.oo..i...o:       ".ToCharArray(),
                "              :....ii...o:       ".ToCharArray(),
                ":~~~~~~~~~~~~~:..........:       ".ToCharArray(),
                ":oo..iii...ii...ii.....oo:       ".ToCharArray(),
                ":o..ii...........i.....oo:       ".ToCharArray(),
                "O.......i..ooo......ii..o:       ".ToCharArray(),
                ":.oo.iii..ooo.oo.....ii..:       ".ToCharArray(),
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
