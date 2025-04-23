using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class UpDrawingMap : MainDrawingMap
    {
        public static void ClearUpNormal(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown + 1]).Remove(character.LeftRight, 1).Insert(character.LeftRight, ".");
            charMap[character.UpDown + 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearUpIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown + IceLineNumber]).Remove(character.LeftRight, 1).Insert(character.LeftRight, ".");
            charMap[character.UpDown + IceLineNumber] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearUpIceHitSomething(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown + IceLineNumber - 1]).Remove(character.LeftRight, 1).Insert(character.LeftRight, ".");
            charMap[character.UpDown + IceLineNumber - 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearUpKeepIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown + IceLineNumber]).Remove(character.LeftRight, 1).Insert(character.LeftRight, "i");
            charMap[character.UpDown + IceLineNumber] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearUpGap(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown + 2]).Remove(character.LeftRight, 1).Insert(character.LeftRight, ".");
            charMap[character.UpDown + 2] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
        }

        public static void ClearUpBoulderOffButton(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown + 1]).Remove(character.LeftRight, 1).Insert(character.LeftRight, "x");
            charMap[character.UpDown + 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearUpFirstButtonChange(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown + 1]).Remove(character.LeftRight, 1).Insert(character.LeftRight, "Q");
            charMap[character.UpDown + 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearUpSecondButtonChange(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown + 1]).Remove(character.LeftRight, 1).Insert(character.LeftRight, "X");
            charMap[character.UpDown + 1] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void ClearUpFirstButtonChangeIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown + IceLineNumber]).Remove(character.LeftRight, 1).Insert(character.LeftRight, "Q");
            charMap[character.UpDown + IceLineNumber] = sb.ToString().ToCharArray();
            sb.Clear();
        }
        public static void ClearUpSecondButtonChangeIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown + IceLineNumber]).Remove(character.LeftRight, 1).Insert(character.LeftRight, "X");
            charMap[character.UpDown + IceLineNumber] = sb.ToString().ToCharArray();
            sb.Clear();
        }
    }
}
