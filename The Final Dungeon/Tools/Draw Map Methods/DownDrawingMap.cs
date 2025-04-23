using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class DownDrawingMap : MainDrawingMap
    {
        public static void ClearDownNormal(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown - 1]).Remove(character.LeftRight, 1).Insert(character.LeftRight, ".");
            charMap[character.UpDown - 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearDownIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown - IceLineNumber]).Remove(character.LeftRight, 1).Insert(character.LeftRight, ".");
            charMap[character.UpDown - IceLineNumber] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearDownIceHitSomething(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown - IceLineNumber + 1]).Remove(character.LeftRight, 1).Insert(character.LeftRight, ".");
            charMap[character.UpDown - IceLineNumber + 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearDownKeepIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown - IceLineNumber]).Remove(character.LeftRight, 1).Insert(character.LeftRight, "i");
            charMap[character.UpDown - IceLineNumber] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearDownGap(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown - 2]).Remove(character.LeftRight, 1).Insert(character.LeftRight, ".");
            charMap[character.UpDown - 2] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
        }

        public static void ClearDownBoulderOffButton(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown - 1]).Remove(character.LeftRight, 1).Insert(character.LeftRight, "x");
            charMap[character.UpDown - 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearDownFirstButtonChange(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown - 1]).Remove(character.LeftRight, 1).Insert(character.LeftRight, "Q");
            charMap[character.UpDown - 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearDownSecondButtonChange(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown - 1]).Remove(character.LeftRight, 1).Insert(character.LeftRight, "X");
            charMap[character.UpDown - 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearDownFirstButtonChangeIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown - IceLineNumber]).Remove(character.LeftRight, 1).Insert(character.LeftRight, "Q");
            charMap[character.UpDown - IceLineNumber] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearDownSecondButtonChangeIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown - IceLineNumber]).Remove(character.LeftRight, 1).Insert(character.LeftRight, "X");
            charMap[character.UpDown - IceLineNumber] = sb.ToString().ToCharArray();
            sb.Clear();
        }
    }
}
