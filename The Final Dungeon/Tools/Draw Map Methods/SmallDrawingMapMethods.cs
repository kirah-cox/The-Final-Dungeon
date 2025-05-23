﻿using System;
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
