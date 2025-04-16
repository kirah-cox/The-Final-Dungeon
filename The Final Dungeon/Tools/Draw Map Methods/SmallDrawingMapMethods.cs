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

        public static void ClearUpGap(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown + 2]).Remove(character.LeftRight, 1).Insert(character.LeftRight, ".");
            charMap[character.UpDown + 2] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
        }

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

        public static void ClearDownGap(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown - 2]).Remove(character.LeftRight, 1).Insert(character.LeftRight, ".");
            charMap[character.UpDown - 2] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
        }

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

        public static void LeftGap(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight + 1, 2).Insert(character.LeftRight + 1, " .");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
        }

        public static void LeftBoulder(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight - 1, 2).Insert(character.LeftRight - 1, $"o{character.CharacterChar}").Remove(character.LeftRight + 1, 1).Insert(character.LeftRight + 1, ".");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

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

        public static void RightGap(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, character.CharacterChar).Remove(character.LeftRight - 2, 1).Insert(character.LeftRight - 2, ".");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
        }

        public static void RightBoulder(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 2).Insert(character.LeftRight, $"{character.CharacterChar}o").Remove(character.LeftRight - 1, 1).Insert(character.LeftRight - 1, ".");
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }
    }
}
