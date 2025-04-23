using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class LeftDrawingMap : MainDrawingMap
    {
        public static void LeftNormal(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight + 1, 1).Insert(character.LeftRight + 1, ".");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }
        public static void LeftIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight + IceLineNumber, 1).Insert(character.LeftRight + IceLineNumber, ".");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void LeftIceHitSomething(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight + IceLineNumber - 1, 1).Insert(character.LeftRight + IceLineNumber - 1, ".");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void LeftKeepIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight + IceLineNumber, 1).Insert(character.LeftRight + IceLineNumber, "i");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void LeftGap(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight + 1, 2).Insert(character.LeftRight + 1, " .");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
        }

        public static void LeftBoulderButton(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight + 1, 1).Insert(character.LeftRight + 1, "x");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void LeftFirstButton(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight + 1, 1).Insert(character.LeftRight + 1, "Q");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void LeftSecondButton(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight + 1, 1).Insert(character.LeftRight + 1, "X");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void LeftFirstButtonIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight + IceLineNumber, 1).Insert(character.LeftRight + IceLineNumber, "Q");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void LeftSecondButtonIce(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight + IceLineNumber, 1).Insert(character.LeftRight + IceLineNumber, "X");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static void LeftBoulder(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight - 1, 2).Insert(character.LeftRight - 1, $"o{character.CharacterChar}").Remove(character.LeftRight + 1, 1).Insert(character.LeftRight + 1, ".");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }
    }
}
