using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllCreations;
using AllMaps;

namespace MyTools
{
    public class MainConsoleKeyMoveMethods : MainMove
    {
        public static void PressedW(char[][] charMap)
        {
            if (charMap[UpDown - 1][LeftRight] == '.')
            {
                SmallConsoleKeyMoveMethods.WNormalMove();
            }
            else if (charMap[UpDown - 1][LeftRight] == 'o')
            {
                SmallConsoleKeyMoveMethods.WPushingBoulder(charMap);
            }
            else if ((charMap[UpDown - 2][LeftRight] == '.') && (charMap[UpDown - 1][LeftRight] == ' ') && ObtainedFeather)
            {
                SmallConsoleKeyMoveMethods.WCrossingGap();
            }
        }

        public static void PressedS(char[][] charMap)
        {
            if (charMap[UpDown + 1][LeftRight] == '.')
            {
                SmallConsoleKeyMoveMethods.SNormalMove();
            }
            else if (charMap[UpDown + 1][LeftRight] == 'o')
            {
                SmallConsoleKeyMoveMethods.SPushingBoulder(charMap);
            }
            else if ((charMap[UpDown + 2][LeftRight] == '.') && (charMap[UpDown + 1][LeftRight] == ' ') && ObtainedFeather)
            {
                SmallConsoleKeyMoveMethods.SCrossingGap();
            }
        }

        public static void PressedA(char[][] charMap)
        {
            if (charMap[UpDown][LeftRight - 1] == '.')
            {
                SmallConsoleKeyMoveMethods.ANormalMove();
            }
            else if (charMap[UpDown][LeftRight - 1] == 'o')
            {
                SmallConsoleKeyMoveMethods.APushingBoulder(charMap);
            }
            else if ((charMap[UpDown][LeftRight - 2] == '.') && (charMap[UpDown][LeftRight - 1] == ' ') && ObtainedFeather)
            {
                SmallConsoleKeyMoveMethods.ACrossingGap();
            }
        }

        public static void PressedD(char[][] charMap)
        {
            if (charMap[UpDown][LeftRight + 1] == '.')
            {
                SmallConsoleKeyMoveMethods.DNormalMove();
            }
            else if (charMap[UpDown][LeftRight + 1] == 'o')
            {
                SmallConsoleKeyMoveMethods.DPushingBoulder(charMap);
            }
            else if (charMap[UpDown][LeftRight + 2] == '.' && (charMap[UpDown][LeftRight + 1] == ' ') && ObtainedFeather)
            {
                SmallConsoleKeyMoveMethods.DCrossingGap();
            }
        }

        public static void PressedE(StringBuilder sb, char[][] charMap, Player player)
        {
            if (!Map.LevelOneChests[MapNumber] && SmallMoveMethods.Characterm(charMap))
            {
                InteractMoveMethods.PotionsChestFull(player);
            }
            else if ((Map.LevelOneChests[MapNumber] && SmallMoveMethods.Characterm(charMap)) || (ObtainedFeather && SmallMoveMethods.CharacterM(charMap)))
            {
                InteractMoveMethods.PotionsChestEmpty();
            }
            else if (SmallMoveMethods.Character0(charMap))
            {
                InteractMoveMethods.MovingToNextRoom(sb, charMap);
            }
            else if (SmallMoveMethods.CharacterO(charMap))
            {
                InteractMoveMethods.MovingToPreviousRoom(sb, charMap);
            }
            else if (!ObtainedKey && SmallMoveMethods.CharacterK(charMap))
            {
                InteractMoveMethods.ObtainingKey(sb, charMap);
            }
            else if (!ObtainedFeather && SmallMoveMethods.CharacterM(charMap))
            {
                InteractMoveMethods.ObtainingFeather();
            }
        }
    }
}
