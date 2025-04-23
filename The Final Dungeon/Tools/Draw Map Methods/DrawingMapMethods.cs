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
            SmallDrawingMapMethods.UpOrDownBoulderNotOverGap(sb, charMap, character);
            SmallDrawingMapMethods.UpOrDownNormal(sb, charMap, character);
        }

        public static void ClearAfterMovingUp(StringBuilder sb, char[][] charMap, Character character)
        {
            if (KeepIce && !BossRoom)
            {
                SmallDrawingMapMethods.IfIceKeptUp(sb, charMap, character);
                return;
            }
            if (IceHitSomething)
            {
                SmallDrawingMapMethods.IfIceHitSomethingUp(sb, charMap, character);

                return;
            }
            if (CrossedGap)
            {
                UpDrawingMap.ClearUpGap(sb, charMap, character);
                return;
            }
            if (CrossingIce && ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight))
            {
                SmallDrawingMapMethods.ChangingButtonUp(sb, charMap, character);
                return;
            }
            if (CrossingIce)
            {
                UpDrawingMap.ClearUpIce(sb, charMap, character);
                return;
            }
            if (BoulderOverButton.Count() > 0 && BoulderOverButton.ContainsKey(character.LeftRight))
            {
                SmallDrawingMapMethods.IfBoulderButtonUp(sb, charMap, character);
                return;
            }
            if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight))
            {
                SmallDrawingMapMethods.ChangingButtonUp(sb, charMap, character);
                return;
            }
            UpDrawingMap.ClearUpNormal(sb, charMap, character);
        }

        public static void ClearAfterMovingDown(StringBuilder sb, char[][] charMap, Character character)
        {
            if (KeepIce && !BossRoom)
            {
                SmallDrawingMapMethods.IfIceKeptDown(sb, charMap, character);
                return;
            }
            if (IceHitSomething)
            {
                SmallDrawingMapMethods.IfIceHitSomethingDown(sb, charMap, character);
                return;
            }
            if (CrossedGap)
            {
                DownDrawingMap.ClearDownGap(sb, charMap, character);
                return;
            }
            if (CrossingIce && ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight))
            {
                SmallDrawingMapMethods.ChangingButtonDown(sb, charMap, character);
                return;
            }
            if (CrossingIce)
            {
                DownDrawingMap.ClearDownIce(sb, charMap, character);
                return;
            }
            if (BoulderOverButton.Count() > 0 && BoulderOverButton.ContainsKey(character.LeftRight))
            {
                SmallDrawingMapMethods.IfBoulderButtonDown(sb, charMap, character);
                return;
            }
            if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight))
            {
                SmallDrawingMapMethods.ChangingButtonDown(sb, charMap, character);
                return;
            }
            DownDrawingMap.ClearDownNormal(sb, charMap, character);
        }

        public static void MoveAndClearLeft(StringBuilder sb, char[][] charMap, Character character)
        {
            if (KeepIce && !BossRoom)
            {
                SmallDrawingMapMethods.IfIceKeptLeft(sb, charMap, character);
                return;
            }
            if (IceHitSomething)
            {
                SmallDrawingMapMethods.IfIceHitSomethingLeft(sb, charMap, character);
                return;
            }
            if (CrossedGap)
            {
                LeftDrawingMap.LeftGap(sb, charMap, character);
                return;
            }
            if (PushingBoulder && !BoulderOverGap)
            {
                SmallDrawingMapMethods.IfPushingBoulderButtonLeft(sb, charMap, character);
                return;
            }
            if (CrossingIce && ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight + IceLineNumber))
            {
                SmallDrawingMapMethods.ChangingButtonLeft(sb, charMap, character);
                return;
            }
            if (CrossingIce)
            {
                LeftDrawingMap.LeftIce(sb, charMap, character);
                return;
            }
            if (BoulderOverButton.Count() > 0 && BoulderOverButton.ContainsKey(character.LeftRight + 1))
            {
                SmallDrawingMapMethods.IfBoulderButtonLeft(sb, charMap, character);
            }
            if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight + 1))
            {
                SmallDrawingMapMethods.ChangingButtonLeft(sb, charMap, character);
                return;
            }
            LeftDrawingMap.LeftNormal(sb, charMap, character);
        }

        public static void MoveAndClearRight(StringBuilder sb, char[][] charMap, Character character)
        {
            if (KeepIce && !BossRoom)
            {
                SmallDrawingMapMethods.IfIceKeptRight(sb, charMap, character);
                return;
            }
            if (IceHitSomething)
            {
                SmallDrawingMapMethods.IfIceHitSomethingRight(sb, charMap, character);
                return;
            }
            if (CrossedGap)
            {
                RightDrawingMap.RightGap(sb, charMap, character);
                return;
            }
            if (PushingBoulder && !BoulderOverGap)
            {
                SmallDrawingMapMethods.IfPushingBoulderButtonRight(sb, charMap, character);
                return;
            }
            if (CrossingIce && ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight - IceLineNumber))
            {
                SmallDrawingMapMethods.ChangingButtonRight(sb, charMap, character);
                return;
            }
            if (CrossingIce)
            {
                RightDrawingMap.RightIce(sb, charMap, character);
                return;
            }
            if (BoulderOverButton.Count() > 0 && BoulderOverButton.ContainsKey(character.LeftRight - 1))
            {
                SmallDrawingMapMethods.IfBoulderButtonRight(sb, charMap, character);
            }
            if (ButtonChange.Count() > 0 && ButtonChange.ContainsKey(character.LeftRight - 1))
            {
                SmallDrawingMapMethods.ChangingButtonRight(sb, charMap, character);
                return;
            }
            RightDrawingMap.RightNormal(sb, charMap, character);
        }
    }
}
