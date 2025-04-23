using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class RightDrawingMap : MainDrawingMap
    {
        public static void RightNormal(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight - 1, 1).Insert(character.LeftRight - 1, ".");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void RightIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight - IceLineNumber, 1).Insert(character.LeftRight - IceLineNumber, ".");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void RightIceHitSomething(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight - IceLineNumber + 1, 1).Insert(character.LeftRight - IceLineNumber + 1, ".");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void RightKeepIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight - IceLineNumber, 1).Insert(character.LeftRight - IceLineNumber, "i");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void RightGap(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight - 2, 1).Insert(character.LeftRight - 2, ".");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
        }

        public static void RightBoulderButton(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight - 1, 1).Insert(character.LeftRight - 1, "x");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void RightFirstButton(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight - 1, 1).Insert(character.LeftRight - 1, "Q");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void RightSecondButton(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight - 1, 1).Insert(character.LeftRight - 1, "X");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void RightFirstButtonIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight - IceLineNumber, 1).Insert(character.LeftRight - IceLineNumber, "Q");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void RightSecondButtonIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight - IceLineNumber, 1).Insert(character.LeftRight - IceLineNumber, "X");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void RightBoulder(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 2).Insert(character.LeftRight, $"{character.CharacterChar}o").Remove(character.LeftRight - 1, 1).Insert(character.LeftRight - 1, ".");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }
    }
}
