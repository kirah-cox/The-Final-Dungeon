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
        public static void PressedW(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown - 1][character.LeftRight] == '.' || charMap[character.UpDown - 1][character.LeftRight] == 'x')
            {
                if (charMap[character.UpDown - 1][character.LeftRight] == 'x' && !BoulderOverButton.ContainsKey(character.LeftRight))
                {
                    BoulderOverButton.Add(character.LeftRight, character.UpDown - 1);
                }
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
            else if (charMap[character.UpDown - 1][character.LeftRight] == 'i')
            {
                CrossingIce = true;
                while (charMap[character.UpDown - 1][character.LeftRight] == 'i')
                {
                    SmallConsoleKeyMoveMethods.WCrossingIce(character);
                    IceLineNumber++;
                }
                SmallConsoleKeyMoveMethods.WNormalMove(character);
            }
        }

        public static void PressedS(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown + 1][character.LeftRight] == '.' || charMap[character.UpDown + 1][character.LeftRight] == 'x')
            {
                if (charMap[character.UpDown + 1][character.LeftRight] == 'x' && !BoulderOverButton.ContainsKey(character.LeftRight))
                {
                    BoulderOverButton.Add(character.LeftRight, character.UpDown + 1);
                }
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
            else if (charMap[character.UpDown + 1][character.LeftRight] == 'i')
            {
                CrossingIce = true;
                while (charMap[character.UpDown + 1][character.LeftRight] == 'i')
                {
                    SmallConsoleKeyMoveMethods.SCrossingIce(character);
                    IceLineNumber++;
                }
                SmallConsoleKeyMoveMethods.SNormalMove(character);
            }
        }

        public static void PressedA(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown][character.LeftRight - 1] == '.' || charMap[character.UpDown][character.LeftRight - 1] == 'x')
            {
                if (charMap[character.UpDown][character.LeftRight - 1] == 'x' && !BoulderOverButton.ContainsKey(character.LeftRight - 1))
                {
                    BoulderOverButton.Add(character.LeftRight - 1, character.UpDown);
                }
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
            else if (charMap[character.UpDown][character.LeftRight - 1] == 'i')
            {
                CrossingIce = true;
                while (charMap[character.UpDown][character.LeftRight - 1] == 'i')
                {
                    SmallConsoleKeyMoveMethods.ACrossingIce(character);
                    IceLineNumber++;
                }
                SmallConsoleKeyMoveMethods.ANormalMove(character);
            }
        }

        public static void PressedD(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown][character.LeftRight + 1] == '.' || charMap[character.UpDown][character.LeftRight + 1] == 'x')
            {
                if (charMap[character.UpDown][character.LeftRight + 1] == 'x' && !BoulderOverButton.ContainsKey(character.LeftRight + 1))
                {
                    BoulderOverButton.Add(character.LeftRight + 1, character.UpDown);
                }
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
            else if (charMap[character.UpDown][character.LeftRight + 1] == 'i')
            {
                CrossingIce = true;
                while (charMap[character.UpDown][character.LeftRight + 1] == 'i')
                {
                    SmallConsoleKeyMoveMethods.DCrossingIce(character);
                    IceLineNumber++;
                }
                SmallConsoleKeyMoveMethods.DNormalMove(character);
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
            else if (SmallMoveMethods.Character0(charMap, character))
            {
                InteractMoveMethods.MovingToNextRoom(sb, charMap, character);
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
            else if (SmallMoveMethods.CharacterB(charMap, character) && ObtainedKey)
            {
                InteractMoveMethods.MovingToNextRoom(sb, charMap, character);
                ObtainedKey = false;
                BossRoom = true;
            }
            else if (SmallMoveMethods.CharacterF(charMap, character))
            {
                BossFight = true;
            }
            else if (SmallMoveMethods.Characterz(charMap, character))
            {
                InteractMoveMethods.MovingToNextLevel(character);
            }
        }
    }
}
