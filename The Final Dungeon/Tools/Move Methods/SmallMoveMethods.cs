using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class SmallMoveMethods : MainMove
    {
        public static void WBoulderNoGap(Character character)
        {
            character.UpDown--;
            character.Up = true;
            PushingBoulder = true;
            BoulderOverGap = false;
            Console.Clear();
        }
        public static void WBoulderGap(Character character)
        {
            character.UpDown--;
            character.Up = true;
            PushingBoulder = true;
            BoulderOverGap = true;
            Console.Clear();
        }
        public static void SBoulderNoGap(Character character)
        {
            character.UpDown++;
            character.Down = true;
            PushingBoulder = true;
            BoulderOverGap = false;
            Console.Clear();
        }
        public static void SBoulderGap(Character character)
        {
            character.UpDown++;
            character.Down = true;
            PushingBoulder = true;
            BoulderOverGap = true;
            Console.Clear();
        }
        public static void ABoulderNoGap(Character character)
        {
            character.LeftRight--;
            character.Left = true;
            PushingBoulder = true;
            BoulderOverGap = false;
            Console.Clear();
        }
        public static void ABoulderGap(Character character)
        {
            character.LeftRight--;
            character.Left = true;
            PushingBoulder = true;
            BoulderOverGap = true;
            Console.Clear();
        }
        public static void DBoulderNoGap(Character character)
        {
            character.LeftRight++;
            character.Right = true;
            PushingBoulder = true;
            BoulderOverGap = false;
            Console.Clear();
        }
        public static void DBoulderGap(Character character)
        {
            character.LeftRight++;
            character.Right = true;
            PushingBoulder = true;
            BoulderOverGap = true;
            Console.Clear();
        }

        public static void ClearCharacterOnMap(StringBuilder sb, char[][] charMap, Character character)
        {
            sb.Append(charMap[character.UpDown]).Remove(character.LeftRight, 1).Insert(character.LeftRight, '.');
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static bool NotCharactersLeftRightPlus(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown][character.LeftRight + 1] != ':'
                && charMap[character.UpDown][character.LeftRight + 1] != 'O'
                && charMap[character.UpDown][character.LeftRight + 1] != '0'
                && charMap[character.UpDown][character.LeftRight + 1] != '#'
                && charMap[character.UpDown][character.LeftRight + 1] != 'B')
            {
                return true;
            }
            return false;
        }

        public static bool NotCharactersLeftRightMinus(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown][character.LeftRight - 1] != ':'
                && charMap[character.UpDown][character.LeftRight - 1] != 'O'
                && charMap[character.UpDown][character.LeftRight - 1] != '0'
                && charMap[character.UpDown][character.LeftRight - 1] != '#'
                && charMap[character.UpDown][character.LeftRight - 1] != 'B')
            {
                return true;
            }
            return false;
        }

        public static bool NotCharactersUpDownPlus(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown + 1][character.LeftRight] != '~'
                && charMap[character.UpDown + 1][character.LeftRight] != 'O'
                && charMap[character.UpDown + 1][character.LeftRight] != '0'
                && charMap[character.UpDown + 1][character.LeftRight] != '#'
                && charMap[character.UpDown + 1][character.LeftRight] != 'B')
            {
                return true;
            }
            return false;
        }

        public static bool NotCharactersUpDownMinus(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown - 1][character.LeftRight] != '~'
                && charMap[character.UpDown - 1][character.LeftRight] != 'O'
                && charMap[character.UpDown - 1][character.LeftRight] != '0'
                && charMap[character.UpDown - 1][character.LeftRight] != '#'
                && charMap[character.UpDown - 1][character.LeftRight] != 'B')
            {
                return true;
            }
            return false;
        }

        public static bool Characterm(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown - 1][character.LeftRight] == 'm'
                || charMap[character.UpDown + 1][character.LeftRight] == 'm'
                || charMap[character.UpDown][character.LeftRight - 1] == 'm'
                || charMap[character.UpDown][character.LeftRight + 1] == 'm')
            {
                return true;
            }
            return false;
        }

        public static bool CharacterM(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown - 1][character.LeftRight] == 'M'
                || charMap[character.UpDown + 1][character.LeftRight] == 'M'
                || charMap[character.UpDown][character.LeftRight - 1] == 'M'
                || charMap[character.UpDown][character.LeftRight + 1] == 'M')
            {
                return true;
            }
            return false;
        }

        public static bool CharacterK(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown - 1][character.LeftRight] == 'K'
                || charMap[character.UpDown + 1][character.LeftRight] == 'K'
                || charMap[character.UpDown][character.LeftRight - 1] == 'K'
                || charMap[character.UpDown][character.LeftRight + 1] == 'K')
            {
                return true;
            }
            return false;
        }

        public static bool CharacterO(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown - 1][character.LeftRight] == 'O'
                || charMap[character.UpDown + 1][character.LeftRight] == 'O'
                || charMap[character.UpDown][character.LeftRight - 1] == 'O'
                || charMap[character.UpDown][character.LeftRight + 1] == 'O')
            {
                return true;
            }
            return false;
        }

        public static bool Character0(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown - 1][character.LeftRight] == '0'
                || charMap[character.UpDown + 1][character.LeftRight] == '0'
                || charMap[character.UpDown][character.LeftRight - 1] == '0'
                || charMap[character.UpDown][character.LeftRight + 1] == '0')
            {
                return true;
            }
            return false;
        }

        public static bool CharacterR(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown - 1][character.LeftRight] == 'R'
                || charMap[character.UpDown + 1][character.LeftRight] == 'R'
                || charMap[character.UpDown][character.LeftRight - 1] == 'R'
                || charMap[character.UpDown][character.LeftRight + 1] == 'R')
            {
                return true;
            }
            return false;
        }

        public static bool CharacterB(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown - 1][character.LeftRight] == 'B'
                || charMap[character.UpDown + 1][character.LeftRight] == 'B'
                || charMap[character.UpDown][character.LeftRight - 1] == 'B'
                || charMap[character.UpDown][character.LeftRight + 1] == 'B')
            {
                return true;
            }
            return false;
        }

        public static bool CharacterF(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown - 1][character.LeftRight] == 'F'
                || charMap[character.UpDown + 1][character.LeftRight] == 'F'
                || charMap[character.UpDown][character.LeftRight - 1] == 'F'
                || charMap[character.UpDown][character.LeftRight + 1] == 'F')
            {
                return true;
            }
            return false;
        }

        public static bool Characterz(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown - 1][character.LeftRight] == 'z'
                || charMap[character.UpDown + 1][character.LeftRight] == 'z'
                || charMap[character.UpDown][character.LeftRight - 1] == 'z'
                || charMap[character.UpDown][character.LeftRight + 1] == 'z')
            {
                return true;
            }
            return false;
        }

        public static bool Characters(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown - 1][character.LeftRight] == 's'
                || charMap[character.UpDown + 1][character.LeftRight] == 's'
                || charMap[character.UpDown][character.LeftRight - 1] == 's'
                || charMap[character.UpDown][character.LeftRight + 1] == 's')
            {
                return true;
            }
            return false;
        }
    }
}
