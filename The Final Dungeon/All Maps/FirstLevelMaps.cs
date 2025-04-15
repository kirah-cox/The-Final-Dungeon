using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMaps
{
    public class FirstLevelMaps
    {
        //sign that says that boulders are pushable?
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
        public static bool FirstChestEmpty { get; set; } = false;

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

        public static bool SecondChestEmpty { get; set; } = false;

        //sign that says that the previous room is the blueprint/solution to the answer undertale style?
        //maybe have some buttons that the boulders need to press, some not, and have a riddle to figure it out?
        //count the number of things and have the answer as a solution to a puzzle?
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
        public static bool ThirdChestEmpty { get; set; } = false;

        public static char[][] FourthMap =
        {
            "         :~~~~~~B~~~~~~:         ".ToCharArray(),
            "         :.............:         ".ToCharArray(),
            "         :.............:         ".ToCharArray(),
            "         :             :         ".ToCharArray(),
            "         :.............:         ".ToCharArray(),
            "         :             :         ".ToCharArray(),
            "         :.............:         ".ToCharArray(),
            "         :.............:         ".ToCharArray(),
            "         O.............:         ".ToCharArray(),
            "         :.............:         ".ToCharArray(),
            "         :~~~~~~~~~~~~~:         ".ToCharArray(),
        };
        public static bool FourthChestEmpty { get; set; } = false;

        public static char[][] BossMap =
        {
            ":~~~~~~~~~~~~~:".ToCharArray(),
            ":.............:".ToCharArray(),
            ":.............:".ToCharArray(),
            ":......F......:".ToCharArray(),
            ":.............:".ToCharArray(),
            ":.............:".ToCharArray(),
            ":~~~~~~~~~~~~~:".ToCharArray(),
        };

        public static List<char[][]> LevelOneMaps = new List<char[][]>()
        {
            FirstMap, SecondMap, ThirdMap, FourthMap, BossMap,
        };

        public static List<bool> LevelOneChests = new List<bool>()
        {
            FirstChestEmpty, SecondChestEmpty, ThirdChestEmpty, FourthChestEmpty,
        };

        public static List<int> LevelOneUpDown = new List<int>()
        {
            1, 5, 2, 9, 1, 6, 8, 0, 5
        };

        public static List<int> LevelOneLeftRight= new List<int>()
        {
            1, 31, 1, 24, 4, 31, 10, 16, 7
        };
    }
}
