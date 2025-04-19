using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class DrawingMapMethods : MainDrawingMap
    {
        public static void CharacterMovesUpOrDown(StringBuilder sb, char[][] charMap, Character character)
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
            
            SmallDrawingMapMethods.UpOrDownNormal(sb, charMap, character);
        }

        public static void ClearAfterMovingUp(StringBuilder sb, char[][] charMap, Character character)
        {
            if (CrossedGap)
            {
                SmallDrawingMapMethods.ClearUpGap(sb, charMap, character);
                return;
            }
            if (CrossingIce)
            {
                SmallDrawingMapMethods.ClearUpIce(sb, charMap, character);
                return;
            }
            if (BoulderOverButton.Count() > 0 && BoulderOverButton.ContainsKey(character.LeftRight))
            {
                if (BoulderOverButton[character.LeftRight] == character.UpDown + 1)
                {
                    SmallDrawingMapMethods.ClearUpBoulderOffButton(sb, charMap, character);
                    return;
                }
            }
            if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight))
            {
                if (ButtonChange[character.LeftRight] == character.UpDown + 1 && ButtonHasChangedX)
                {
                    SmallDrawingMapMethods.ClearUpFirstButtonChange(sb, charMap, character);
                    ButtonHasChangedX = false;
                    return;
                }
                if (ButtonChange[character.LeftRight] == character.UpDown + 1 && ButtonHasChangedQ)
                {
                    SmallDrawingMapMethods.ClearUpSecondButtonChange(sb, charMap, character);
                    ButtonHasChangedQ = false;
                    return;
                }
            }
            SmallDrawingMapMethods.ClearUpNormal(sb, charMap, character);
        }

        public static void ClearAfterMovingDown(StringBuilder sb, char[][] charMap, Character character)
        {
            if (CrossedGap)
            {
                SmallDrawingMapMethods.ClearDownGap(sb, charMap, character);
                return;
            }
            if (CrossingIce)
            {
                SmallDrawingMapMethods.ClearDownIce(sb, charMap, character);
                return;
            }
            if (BoulderOverButton.Count() > 0 && BoulderOverButton.ContainsKey(character.LeftRight))
            {
                if (BoulderOverButton[character.LeftRight] == character.UpDown - 1)
                {
                    SmallDrawingMapMethods.ClearDownBoulderOffButton(sb, charMap, character);
                    return;
                }
            }
            if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight))
            {
                if (ButtonChange[character.LeftRight] == character.UpDown - 1 && ButtonHasChangedX)
                {
                    SmallDrawingMapMethods.ClearDownFirstButtonChange(sb, charMap, character);
                    ButtonHasChangedX = false;
                    return;
                }
                if (ButtonChange[character.LeftRight] == character.UpDown - 1 && ButtonHasChangedQ)
                {
                    SmallDrawingMapMethods.ClearDownSecondButtonChange(sb, charMap, character);
                    ButtonHasChangedQ = false;
                    return;
                }
            }
            SmallDrawingMapMethods.ClearDownNormal(sb, charMap, character);
        }

        public static void MoveAndClearLeft(StringBuilder sb, char[][] charMap, Character character)
        {
            if (CrossedGap)
            {
                SmallDrawingMapMethods.LeftGap(sb, charMap, character);
                return;
            }
            if (PushingBoulder && !BoulderOverGap)
            {
                SmallDrawingMapMethods.LeftBoulder(sb, charMap, character);
                if (BoulderOverButton.Count() > 0 && BoulderOverButton.ContainsKey(character.LeftRight + 1))
                {
                    if (BoulderOverButton[character.LeftRight + 1] == character.UpDown)
                    {
                        SmallDrawingMapMethods.LeftBoulderButton(sb, charMap, character);
                    }
                }
                return;
            }
            if (CrossingIce)
            {
                SmallDrawingMapMethods.LeftIce(sb, charMap, character);
                return;
            }
            if (BoulderOverButton.Count() > 0 && BoulderOverButton.ContainsKey(character.LeftRight + 1))
            {
                if (BoulderOverButton[character.LeftRight + 1] == character.UpDown)
                {
                    SmallDrawingMapMethods.LeftBoulderButton(sb, charMap, character);
                    return;
                }
            }
            if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight + 1))
            {
                if (ButtonChange[character.LeftRight + 1] == character.UpDown && ButtonHasChangedX)
                {
                    SmallDrawingMapMethods.LeftFirstButton(sb, charMap, character);
                    ButtonHasChangedX = false;
                    return;
                }
                if (ButtonChange[character.LeftRight + 1] == character.UpDown && ButtonHasChangedQ)
                {
                    SmallDrawingMapMethods.LeftSecondButton(sb, charMap, character);
                    ButtonHasChangedQ = false;
                    return;
                }
            }
            SmallDrawingMapMethods.LeftNormal(sb, charMap, character);
        }

        public static void MoveAndClearRight(StringBuilder sb, char[][] charMap, Character character)
        {
            if (CrossedGap)
            {
                SmallDrawingMapMethods.RightGap(sb, charMap, character);
                return;
            }
            if (PushingBoulder && !BoulderOverGap)
            {
                SmallDrawingMapMethods.RightBoulder(sb, charMap, character);
                if (BoulderOverButton.Count() > 0 && BoulderOverButton.ContainsKey(character.LeftRight - 1))
                {
                    if (BoulderOverButton[character.LeftRight - 1] == character.UpDown)
                    {
                        SmallDrawingMapMethods.RightBoulderButton(sb, charMap, character);
                    }
                }
                return;
            }
            if (CrossingIce)
            {
                SmallDrawingMapMethods.RightIce(sb, charMap, character);
                return;
            }
            if (BoulderOverButton.Count() > 0 && BoulderOverButton.ContainsKey(character.LeftRight - 1))
            {
                if (BoulderOverButton[character.LeftRight - 1] == character.UpDown)
                {
                    SmallDrawingMapMethods.RightBoulderButton(sb, charMap, character);
                    return;
                }
            }
            if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight - 1))
            {
                if (ButtonChange[character.LeftRight - 1] == character.UpDown && ButtonHasChangedX)
                {
                    SmallDrawingMapMethods.RightFirstButton(sb, charMap, character);
                    ButtonHasChangedX = false;
                    return;
                }
                if (ButtonChange[character.LeftRight - 1] == character.UpDown && ButtonHasChangedQ)
                {
                    SmallDrawingMapMethods.RightSecondButton(sb, charMap, character);
                    ButtonHasChangedQ = false;
                    return;
                }
            }
            SmallDrawingMapMethods.RightNormal(sb, charMap, character);
        }
    }
}
