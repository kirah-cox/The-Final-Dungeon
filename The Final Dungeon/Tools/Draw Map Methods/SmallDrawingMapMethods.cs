using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace MyTools
{
    public class SmallDrawingMapMethods : MainDrawingMap
    {
        public static void UpOrDownBoulderNotOverGap(StringBuilder sb, char[][] charMap, Character character)
        {
            if (PushingBoulder && !BoulderOverGap)
            {
                if (character.Up)
                {
                    SmallDrawingMapMethods.UpOrDownBoulderUp(sb, charMap, character);
                }
                if (character.Down)
                {
                    SmallDrawingMapMethods.UpOrDownBoulderDown(sb, charMap, character);
                }
                return;
            }
        }
        public static void UpOrDownNormal(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar);
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void UpOrDownBoulderUp(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar);
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            sb.Append(charMap[character.UpDown - 1]).Remove(character.LeftRight, 1).Insert(character.LeftRight, 'o');
            charMap[character.UpDown - 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void UpOrDownBoulderDown(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar);
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            sb.Append(charMap[character.UpDown + 1]).Remove(character.LeftRight, 1).Insert(character.LeftRight, 'o');
            charMap[character.UpDown + 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }
        public static void ChangingButtonUp(StringBuilder sb, char[][] charMap, Character character)
        {
            if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight) && ButtonHasChangedX)
            {
                ChangingButtonUpX(sb, charMap, character);
            }
            else if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight) && ButtonHasChangedQ)
            {
                ChangingButtonUpQ(sb, charMap, character);
            }
        }

        public static void ChangingButtonUpX(StringBuilder sb, char[][] charMap, Character character)
        {
            if (ButtonChange[character.LeftRight] == character.UpDown + 1)
            {
                UpDrawingMap.ClearUpFirstButtonChange(sb, charMap, character);
                ButtonHasChangedX = false;
            }
        }

        public static void ChangingButtonUpQ(StringBuilder sb, char[][] charMap, Character character)
        {
            if (ButtonChange[character.LeftRight] == character.UpDown + 1)
            {
                UpDrawingMap.ClearUpSecondButtonChange(sb, charMap, character);
                ButtonHasChangedQ = false;
            }
        }

        public static void ChangingButtonDown(StringBuilder sb, char[][] charMap, Character character)
        {
            if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight) && ButtonHasChangedX)
            {
                ChangingButtonDownX(sb, charMap, character);
            }
            else if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight) && ButtonHasChangedQ)
            {
                ChangingButtonDownQ(sb, charMap, character);
            }
        }

        public static void ChangingButtonDownX(StringBuilder sb, char[][] charMap, Character character)
        {
            if (ButtonChange[character.LeftRight] == character.UpDown - 1)
            {
                UpDrawingMap.ClearUpFirstButtonChange(sb, charMap, character);
                ButtonHasChangedX = false;
            }
        }

        public static void ChangingButtonDownQ(StringBuilder sb, char[][] charMap, Character character)
        {
            if (ButtonChange[character.LeftRight] == character.UpDown - 1)
            {
                UpDrawingMap.ClearUpSecondButtonChange(sb, charMap, character);
                ButtonHasChangedQ = false;
            }
        }

        public static void ChangingButtonLeft(StringBuilder sb, char[][] charMap, Character character)
        {
            if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight + 1) && ButtonHasChangedX)
            {
                ChangingButtonLeftX(sb, charMap, character);
            }
            else if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight + 1) && ButtonHasChangedQ)
            {
                ChangingButtonLeftQ(sb, charMap, character);
            }
        }

        public static void ChangingButtonLeftX(StringBuilder sb, char[][] charMap, Character character)
        {
            if (ButtonChange[character.LeftRight + 1] == character.UpDown)
            {
                UpDrawingMap.ClearUpFirstButtonChange(sb, charMap, character);
                ButtonHasChangedX = false;
            }
        }

        public static void ChangingButtonLeftQ(StringBuilder sb, char[][] charMap, Character character)
        {
            if (ButtonChange[character.LeftRight + 1] == character.UpDown)
            {
                UpDrawingMap.ClearUpSecondButtonChange(sb, charMap, character);
                ButtonHasChangedQ = false;
            }
        }

        public static void ChangingButtonRight(StringBuilder sb, char[][] charMap, Character character)
        {
            if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight - 1) && ButtonHasChangedX)
            {
                ChangingButtonRightX(sb, charMap, character);
            }
            else if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight - 1) && ButtonHasChangedQ)
            {
                ChangingButtonRightQ(sb, charMap, character);
            }
        }

        public static void ChangingButtonRightX(StringBuilder sb, char[][] charMap, Character character)
        {
            if (ButtonChange[character.LeftRight - 1] == character.UpDown)
            {
                UpDrawingMap.ClearUpFirstButtonChange(sb, charMap, character);
                ButtonHasChangedX = false;
            }
        }

        public static void ChangingButtonRightQ(StringBuilder sb, char[][] charMap, Character character)
        {
            if (ButtonChange[character.LeftRight - 1] == character.UpDown)
            {
                UpDrawingMap.ClearUpSecondButtonChange(sb, charMap, character);
                ButtonHasChangedQ = false;
            }
        }

        public static void IfIceKeptUp(StringBuilder sb, char[][] charMap, Character character)
        {
            UpDrawingMap.ClearUpKeepIce(sb, charMap, character);
            ChangingButtonUp(sb, charMap, character);
            if (!IceHitSomething)
            {
                KeepIce = false;
            }
        }

        public static void IfIceHitSomethingUp(StringBuilder sb, char[][] charMap, Character character)
        {
            UpDrawingMap.ClearUpIceHitSomething(sb, charMap, character);
            KeepIce = true;
            ChangingButtonUp(sb, charMap, character);
        }

        public static void IfBoulderButtonUp(StringBuilder sb, char[][] charMap, Character character)
        {
            if (BoulderOverButton[character.LeftRight] == character.UpDown + 1)
            {
                UpDrawingMap.ClearUpBoulderOffButton(sb, charMap, character);
            }
        }

        public static void IfIceKeptDown(StringBuilder sb, char[][] charMap, Character character)
        {
            DownDrawingMap.ClearDownKeepIce(sb, charMap, character);
            ChangingButtonDown(sb, charMap, character);
            if (!IceHitSomething)
            {
                KeepIce = false;
            }
        }

        public static void IfIceHitSomethingDown(StringBuilder sb, char[][] charMap, Character character)
        {
            DownDrawingMap.ClearDownIceHitSomething(sb, charMap, character);
            KeepIce = true;
            ChangingButtonDown(sb, charMap, character);
        }

        public static void IfBoulderButtonDown(StringBuilder sb, char[][] charMap, Character character)
        {
            if (BoulderOverButton[character.LeftRight] == character.UpDown - 1)
            {
                DownDrawingMap.ClearDownBoulderOffButton(sb, charMap, character);
            }
        }

        public static void IfIceKeptLeft(StringBuilder sb, char[][] charMap, Character character)
        {
            LeftDrawingMap.LeftKeepIce(sb, charMap, character);
            ChangingButtonLeft(sb, charMap, character);
            if (!IceHitSomething)
            {
                KeepIce = false;
            }
        }

        public static void IfIceHitSomethingLeft(StringBuilder sb, char[][] charMap, Character character)
        {
            LeftDrawingMap.LeftIceHitSomething(sb, charMap, character);
            KeepIce = true;
            ChangingButtonLeft(sb, charMap, character);
        }

        public static void IfBoulderButtonLeft(StringBuilder sb, char[][] charMap, Character character)
        {
            if (BoulderOverButton[character.LeftRight + 1] == character.UpDown)
            {
                LeftDrawingMap.LeftBoulderButton(sb, charMap, character);
            }
        }

        public static void IfPushingBoulderButtonLeft(StringBuilder sb, char[][] charMap, Character character)
        {
            LeftDrawingMap.LeftBoulder(sb, charMap, character);
            if (BoulderOverButton.Count() > 0 && BoulderOverButton.ContainsKey(character.LeftRight + 1))
            {
                IfBoulderButtonLeft(sb, charMap, character);
            }
        }

        public static void IfIceKeptRight(StringBuilder sb, char[][] charMap, Character character)
        {
            RightDrawingMap.RightKeepIce(sb, charMap, character);
            ChangingButtonRight(sb, charMap, character);
            if (!IceHitSomething)
            {
                KeepIce = false;
            }
        }

        public static void IfIceHitSomethingRight(StringBuilder sb, char[][] charMap, Character character)
        {
            RightDrawingMap.RightIceHitSomething(sb, charMap, character);
            KeepIce = true;
            ChangingButtonRight(sb, charMap, character);
        }

        public static void IfBoulderButtonRight(StringBuilder sb, char[][] charMap, Character character)
        {
            if (BoulderOverButton[character.LeftRight - 1] == character.UpDown)
            {
                RightDrawingMap.RightBoulderButton(sb, charMap, character);
            }
        }

        public static void IfPushingBoulderButtonRight(StringBuilder sb, char[][] charMap, Character character)
        {
            RightDrawingMap.RightBoulder(sb, charMap, character);
            if (BoulderOverButton.Count() > 0 && BoulderOverButton.ContainsKey(character.LeftRight - 1))
            {
                SmallDrawingMapMethods.IfBoulderButtonRight(sb, charMap, character);
            }
        }
    }   
}
