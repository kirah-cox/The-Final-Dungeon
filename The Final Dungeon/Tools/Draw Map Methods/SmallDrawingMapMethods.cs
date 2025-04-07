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
        public static void UpOrDownNormal(StringBuilder sb, char[][] charMap, string character)
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character);
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void UpOrDownBoulderUp(StringBuilder sb, char[][] charMap, string character)
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character);
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            sb.Append(charMap[UpDown - 1]).Remove(LeftRight, 1).Insert(LeftRight, 'o');
            charMap[UpDown - 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void UpOrDownBoulderDown(StringBuilder sb, char[][] charMap, string character)
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character);
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            sb.Append(charMap[UpDown + 1]).Remove(LeftRight, 1).Insert(LeftRight, 'o');
            charMap[UpDown + 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearUpNormal(StringBuilder sb, char[][] charMap)
        {
            sb.Append(charMap[UpDown + 1]).Remove(LeftRight, 1).Insert(LeftRight, ".");
            charMap[UpDown + 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearUpGap(StringBuilder sb, char[][] charMap)
        {
            sb.Append(charMap[UpDown + 2]).Remove(LeftRight, 1).Insert(LeftRight, ".");
            charMap[UpDown + 2] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
        }

        public static void ClearDownNormal(StringBuilder sb, char[][] charMap)
        {
            sb.Append(charMap[UpDown - 1]).Remove(LeftRight, 1).Insert(LeftRight, ".");
            charMap[UpDown - 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearDownGap(StringBuilder sb, char[][] charMap)
        {
            sb.Append(charMap[UpDown - 2]).Remove(LeftRight, 1).Insert(LeftRight, ".");
            charMap[UpDown - 2] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
        }

        public static void LeftNormal(StringBuilder sb, char[][] charMap, string character)
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character).Remove(LeftRight + 1, 1).Insert(LeftRight + 1, ".");
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void LeftGap(StringBuilder sb, char[][] charMap, string character)
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character).Remove(LeftRight + 1, 2).Insert(LeftRight + 1, " .");
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
        }

        public static void LeftBoulder(StringBuilder sb, char[][] charMap, string character)
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight - 1, 2).Insert(LeftRight - 1, $"o{character}").Remove(LeftRight + 1, 1).Insert(LeftRight + 1, ".");
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void RightNormal(StringBuilder sb, char[][] charMap, string character)
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character).Remove(LeftRight - 1, 1).Insert(LeftRight - 1, ".");
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void RightGap(StringBuilder sb, char[][] charMap, string character)
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character).Remove(LeftRight - 2, 1).Insert(LeftRight - 2, ".");
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
        }

        public static void RightBoulder(StringBuilder sb, char[][] charMap, string character)
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 2).Insert(LeftRight, $"{character}o").Remove(LeftRight - 1, 1).Insert(LeftRight - 1, ".");
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }
    }
}
