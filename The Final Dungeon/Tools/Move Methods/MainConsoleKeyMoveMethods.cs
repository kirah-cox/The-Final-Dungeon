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
            if (charMap[character.UpDown - 1][character.LeftRight] == '.' || charMap[character.UpDown - 1][character.LeftRight] == 'x' || charMap[character.UpDown - 1][character.LeftRight] == 'X' || charMap[character.UpDown - 1][character.LeftRight] == 'Q')
            {
                if (charMap[character.UpDown - 1][character.LeftRight] == 'x' && !BoulderOverButton.ContainsKey(character.LeftRight))
                {
                    BoulderOverButton.Add(character.LeftRight, character.UpDown - 1);
                }
                if (charMap[character.UpDown - 1][character.LeftRight] == 'X')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight))
                    {
                        ButtonChange.Add(character.LeftRight, character.UpDown - 1);
                    }
                    ButtonHasChangedX = true;
                }
                else if (charMap[character.UpDown - 1][character.LeftRight] == 'Q')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight))
                    {
                        ButtonChange.Add(character.LeftRight, character.UpDown - 1);
                    }
                    ButtonHasChangedQ = true;
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
                if (charMap[character.UpDown - 1][character.LeftRight] == 'X')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight))
                    {
                        ButtonChange.Add(character.LeftRight, character.UpDown - 1);
                    }
                    ButtonHasChangedX = true;
                }
                else if (charMap[character.UpDown - 1][character.LeftRight] == 'Q')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight))
                    {
                        ButtonChange.Add(character.LeftRight, character.UpDown - 1);
                    }
                    ButtonHasChangedQ = true;
                }
                if (SmallMoveMethods.NotCharactersUpDownMinus(charMap, character) && !SmallMoveMethods.Characterm(charMap, character) && !SmallMoveMethods.CharacterK(charMap, character) && !SmallMoveMethods.CharacterM(charMap, character))
                {
                    SmallConsoleKeyMoveMethods.WNormalMove(character);
                }
                else
                {
                    IceHitSomething = true;
                }
            }
        }

        public static void PressedS(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown + 1][character.LeftRight] == '.' || charMap[character.UpDown + 1][character.LeftRight] == 'x' || charMap[character.UpDown + 1][character.LeftRight] == 'X' || charMap[character.UpDown + 1][character.LeftRight] == 'Q')
            {
                if (charMap[character.UpDown + 1][character.LeftRight] == 'x' && !BoulderOverButton.ContainsKey(character.LeftRight))
                {
                    BoulderOverButton.Add(character.LeftRight, character.UpDown + 1);
                }
                if (charMap[character.UpDown + 1][character.LeftRight] == 'X')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight))
                    {
                        ButtonChange.Add(character.LeftRight, character.UpDown + 1);
                    }
                    ButtonHasChangedX = true;
                }
                else if (charMap[character.UpDown + 1][character.LeftRight] == 'Q')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight))
                    {
                        ButtonChange.Add(character.LeftRight, character.UpDown + 1);
                    }
                    ButtonHasChangedQ = true;
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
                if (charMap[character.UpDown + 1][character.LeftRight] == 'X')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight))
                    {
                        ButtonChange.Add(character.LeftRight, character.UpDown + 1);
                    }
                    ButtonHasChangedX = true;
                }
                else if (charMap[character.UpDown + 1][character.LeftRight] == 'Q')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight))
                    {
                        ButtonChange.Add(character.LeftRight, character.UpDown + 1);
                    }
                    ButtonHasChangedQ = true;
                }
                if (SmallMoveMethods.NotCharactersUpDownPlus(charMap, character) && !SmallMoveMethods.Characterm(charMap, character) && !SmallMoveMethods.CharacterK(charMap, character) && !SmallMoveMethods.CharacterM(charMap, character))
                {
                    SmallConsoleKeyMoveMethods.SNormalMove(character);
                }
                else
                {
                    IceHitSomething = true;
                }
            }
        }

        public static void PressedA(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown][character.LeftRight - 1] == '.' || charMap[character.UpDown][character.LeftRight - 1] == 'x' || charMap[character.UpDown][character.LeftRight - 1] == 'X' || charMap[character.UpDown][character.LeftRight - 1] == 'Q')
            {
                if (charMap[character.UpDown][character.LeftRight - 1] == 'x' && !BoulderOverButton.ContainsKey(character.LeftRight - 1))
                {
                    BoulderOverButton.Add(character.LeftRight - 1, character.UpDown);
                }
                if (charMap[character.UpDown][character.LeftRight - 1] == 'X')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight - 1))
                    {
                        ButtonChange.Add(character.LeftRight - 1, character.UpDown);
                    }
                    ButtonHasChangedX = true;
                }
                else if (charMap[character.UpDown][character.LeftRight - 1] == 'Q')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight - 1))
                    {
                        ButtonChange.Add(character.LeftRight - 1, character.UpDown);
                    }
                    ButtonHasChangedQ = true;
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
                if (charMap[character.UpDown][character.LeftRight - 1] == 'X')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight - 1))
                    {
                        ButtonChange.Add(character.LeftRight - 1, character.UpDown);
                    }
                    ButtonHasChangedX = true;
                }
                else if (charMap[character.UpDown][character.LeftRight - 1] == 'Q')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight - 1))
                    {
                        ButtonChange.Add(character.LeftRight - 1, character.UpDown);
                    }
                    ButtonHasChangedQ = true;
                }
                if (SmallMoveMethods.NotCharactersLeftRightMinus(charMap, character) && !SmallMoveMethods.Characterm(charMap, character) && !SmallMoveMethods.CharacterK(charMap, character) && !SmallMoveMethods.CharacterM(charMap, character))
                {
                    SmallConsoleKeyMoveMethods.ANormalMove(character);
                }
                else
                {
                    IceHitSomething = true;
                }
            }
        }

        public static void PressedD(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown][character.LeftRight + 1] == '.' || charMap[character.UpDown][character.LeftRight + 1] == 'x' || charMap[character.UpDown][character.LeftRight + 1] == 'X' || charMap[character.UpDown][character.LeftRight + 1] == 'Q')
            {
                if (charMap[character.UpDown][character.LeftRight + 1] == 'x' && !BoulderOverButton.ContainsKey(character.LeftRight + 1))
                {
                    BoulderOverButton.Add(character.LeftRight + 1, character.UpDown);
                }
                if (charMap[character.UpDown][character.LeftRight + 1] == 'X')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight + 1))
                    {
                        ButtonChange.Add(character.LeftRight + 1, character.UpDown);
                    }
                    ButtonHasChangedX = true;
                }
                else if (charMap[character.UpDown][character.LeftRight + 1] == 'Q')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight + 1))
                    {
                        ButtonChange.Add(character.LeftRight + 1, character.UpDown);
                    }
                    ButtonHasChangedQ = true;
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
                if (charMap[character.UpDown][character.LeftRight + 1] == 'X')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight + 1))
                    {
                        ButtonChange.Add(character.LeftRight + 1, character.UpDown);
                    }
                    ButtonHasChangedX = true;
                }
                else if (charMap[character.UpDown][character.LeftRight + 1] == 'Q')
                {
                    if (!ButtonChange.ContainsKey(character.LeftRight + 1))
                    {
                        ButtonChange.Add(character.LeftRight + 1, character.UpDown);
                    }
                    ButtonHasChangedQ = true;
                }
                if (SmallMoveMethods.NotCharactersLeftRightPlus(charMap, character) && !SmallMoveMethods.Characterm(charMap, character) && !SmallMoveMethods.CharacterK(charMap, character) && !SmallMoveMethods.CharacterM(charMap, character))
                {
                    SmallConsoleKeyMoveMethods.DNormalMove(character);
                }
                else
                {
                    IceHitSomething = true;
                }
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
            else if (SmallMoveMethods.CharacterM(charMap, character))
            {
                if (!ObtainedFeather && LevelNumber == 0)
                {
                    InteractMoveMethods.ObtainingFeather();
                }
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
            else if (SmallMoveMethods.Characters(charMap, character))
            {
                if (LevelNumber == 0)
                {
                    Console.Clear();
                    Console.WriteLine("|-----------------------------------|");
                    Console.WriteLine("|                                   |");
                    Console.WriteLine("|   The boulders are light enough   |");
                    Console.WriteLine("|          to push around.          |");
                    Console.WriteLine("|                                   |");
                    Console.WriteLine("|   All of the buttons need to be   |");
                    Console.WriteLine("|    pressed at once to continue.   |");
                    Console.WriteLine("|                                   |");
                    Console.WriteLine("|-----------------------------------|");
                    Console.WriteLine("                 | |                 ");
                    Console.WriteLine("                 | |                 ");
                    Console.WriteLine("                 | |                 ");
                    Console.WriteLine("                 | |                 ");
                    Console.WriteLine("                 |_|                 ");
                    Console.WriteLine("\n");
                    PressEnter();
                    Console.Clear();
                }
            }
        }
    }
}
