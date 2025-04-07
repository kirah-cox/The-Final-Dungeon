using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class DrawingMapMethods : MainDrawingMap
    {
        public static void CharacterMovesUpOrDown(StringBuilder sb, char[][] charMap, string character)
        {
            if (PushingBoulder && !BoulderOverGap)
            {
                if (Up)
                {
                    SmallDrawingMapMethods.UpOrDownBoulderUp(sb, charMap, character);
                }
                if (Down)
                {
                    SmallDrawingMapMethods.UpOrDownBoulderDown(sb, charMap, character);
                }
                return;
            }
            SmallDrawingMapMethods.UpOrDownNormal(sb, charMap, character);
        }

        public static void ClearAfterMovingUp(StringBuilder sb, char[][] charMap, string character)
        {
            if (CrossedGap)
            {
                SmallDrawingMapMethods.ClearUpGap(sb, charMap);
                return;
            }
            SmallDrawingMapMethods.ClearUpNormal(sb, charMap);
        }

        public static void ClearAfterMovingDown(StringBuilder sb, char[][] charMap, string character)
        {
            if (CrossedGap)
            {
                SmallDrawingMapMethods.ClearDownGap(sb, charMap);
                return;
            }
            SmallDrawingMapMethods.ClearDownNormal(sb, charMap);
        }

        public static void MoveAndClearLeft(StringBuilder sb, char[][] charMap, string character)
        {
            if (CrossedGap)
            {
                SmallDrawingMapMethods.LeftGap(sb, charMap, character);
                return;
            }
            if (PushingBoulder && !BoulderOverGap)
            {
                SmallDrawingMapMethods.LeftBoulder(sb, charMap, character);
                return;
            }
            SmallDrawingMapMethods.LeftNormal(sb, charMap, character);
        }

        public static void MoveAndClearRight(StringBuilder sb, char[][] charMap, string character)
        {
            if (CrossedGap)
            {
                SmallDrawingMapMethods.RightGap(sb, charMap, character);
                return;
            }
            if (PushingBoulder && !BoulderOverGap)
            {
                SmallDrawingMapMethods.RightBoulder(sb, charMap, character);
                return;
            }
            SmallDrawingMapMethods.RightNormal(sb, charMap, character);
        }
    }
}
