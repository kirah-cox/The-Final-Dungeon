using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllCreations;
using AllMaps;
using AllProjectiles;

namespace MyTools
{
    public class MainConsoleKeyMoveMethods : MainMove
    {
        public static void PressedW(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown - 1][character.LeftRight] == '.')
            {
                SmallConsoleKeyMoveMethods.WNormalMove(character);
            }
            else if (charMap[character.UpDown - 1][character.LeftRight] == 'o')
            {
                SmallConsoleKeyMoveMethods.WPushingBoulder(charMap, character);
            }
            else if ((charMap[character.UpDown - 2][character.LeftRight] == '.') && (charMap[character.UpDown - 1][character.LeftRight] == ' ') && ObtainedFeather)
            {
                SmallConsoleKeyMoveMethods.WCrossingGap(character);
            }
        }

        public static void PressedS(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown + 1][character.LeftRight] == '.')
            {
                SmallConsoleKeyMoveMethods.SNormalMove(character);
            }
            else if (charMap[character.UpDown + 1][character.LeftRight] == 'o')
            {
                SmallConsoleKeyMoveMethods.SPushingBoulder(charMap, character);
            }
            else if ((charMap[character.UpDown + 2][character.LeftRight] == '.') && (charMap[character.UpDown + 1][character.LeftRight] == ' ') && ObtainedFeather)
            {
                SmallConsoleKeyMoveMethods.SCrossingGap(character);
            }
        }

        public static void PressedA(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown][character.LeftRight - 1] == '.')
            {
                SmallConsoleKeyMoveMethods.ANormalMove(character);
            }
            else if (charMap[character.UpDown][character.LeftRight - 1] == 'o')
            {
                SmallConsoleKeyMoveMethods.APushingBoulder(charMap, character);
            }
            else if ((charMap[character.UpDown][character.LeftRight - 2] == '.') && (charMap[character.UpDown][character.LeftRight - 1] == ' ') && ObtainedFeather)
            {
                SmallConsoleKeyMoveMethods.ACrossingGap(character);
            }
        }

        public static void PressedD(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown][character.LeftRight + 1] == '.')
            {
                SmallConsoleKeyMoveMethods.DNormalMove(character);
            }
            else if (charMap[character.UpDown][character.LeftRight + 1] == 'o')
            {
                SmallConsoleKeyMoveMethods.DPushingBoulder(charMap, character);
            }
            else if (charMap[character.UpDown][character.LeftRight + 2] == '.' && (charMap[character.UpDown][character.LeftRight + 1] == ' ') && ObtainedFeather)
            {
                SmallConsoleKeyMoveMethods.DCrossingGap(character);
            }
        }

        public static void PressedE(StringBuilder sb, char[][] charMap, Player player, Character character)
        {
            if (!FirstLevelMaps.LevelOneChests[MapNumber] && SmallMoveMethods.Characterm(charMap, character))
            {
                InteractMoveMethods.PotionsChestFull(player);
            }
            else if ((FirstLevelMaps.LevelOneChests[MapNumber] && SmallMoveMethods.Characterm(charMap, character)) || (ObtainedFeather && SmallMoveMethods.CharacterM(charMap, character)))
            {
                InteractMoveMethods.PotionsChestEmpty();
            }
            else if (SmallMoveMethods.Character0(charMap, character) && MapNumber + 1 != 4)
            {
                InteractMoveMethods.MovingToNextRoom(sb, charMap, character);
            }
            else if (SmallMoveMethods.Character0(charMap, character) && MapNumber + 1 == 4)
            {
                InteractMoveMethods.MovingToNextRoom(sb, charMap, character);
                BossFight = true;
            }
            else if (SmallMoveMethods.CharacterO(charMap, character))
            {
                InteractMoveMethods.MovingToPreviousRoom(sb, charMap, character);
            }
            else if (!ObtainedKey && SmallMoveMethods.CharacterK(charMap, character))
            {
                InteractMoveMethods.ObtainingKey(sb, charMap, character);
            }
            else if (!ObtainedFeather && SmallMoveMethods.CharacterM(charMap, character))
            {
                InteractMoveMethods.ObtainingFeather();
            }
            else if (SmallMoveMethods.CharacterR(charMap, character))
            {
                InteractMoveMethods.ResetBoulders();
            }
        }
    }
}
