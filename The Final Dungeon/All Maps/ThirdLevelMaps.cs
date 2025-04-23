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
        public static bool FirstChestEmpty { get; set; } = false;

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

        public static bool SecondChestEmpty { get; set; } = false;

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
        public static bool ThirdChestEmpty { get; set; } = false;

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
