using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class SmallMoveMethods : MainMove
    {
        public static void WBoulderNoGap()
        {
            UpDown--;
            Up = true;
            PushingBoulder = true;
            BoulderOverGap = false;
            Console.Clear();
        }
        public static void WBoulderGap()
        {
            UpDown--;
            Up = true;
            PushingBoulder = true;
            BoulderOverGap = true;
            Console.Clear();
        }
        public static void SBoulderNoGap()
        {
            UpDown++;
            Down = true;
            PushingBoulder = true;
            BoulderOverGap = false;
            Console.Clear();
        }
        public static void SBoulderGap()
        {
            UpDown++;
            Down = true;
            PushingBoulder = true;
            BoulderOverGap = true;
            Console.Clear();
        }
        public static void ABoulderNoGap()
        {
            LeftRight--;
            Left = true;
            PushingBoulder = true;
            BoulderOverGap = false;
            Console.Clear();
        }
        public static void ABoulderGap()
        {
            LeftRight--;
            Left = true;
            PushingBoulder = true;
            BoulderOverGap = true;
            Console.Clear();
        }
        public static void DBoulderNoGap()
        {
            LeftRight++;
            Right = true;
            PushingBoulder = true;
            BoulderOverGap = false;
            Console.Clear();
        }
        public static void DBoulderGap()
        {
            LeftRight++;
            Right = true;
            PushingBoulder = true;
            BoulderOverGap = true;
            Console.Clear();
        }

        public static void ClearCharacterOnMap(StringBuilder sb, char[][] charMap)
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, '.');
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
        }

        public static bool NotCharactersLeftRightPlus(char[][] charMap)
        {
            if (charMap[UpDown][LeftRight + 1] != ':'
                && charMap[UpDown][LeftRight + 1] != 'O'
                && charMap[UpDown][LeftRight + 1] != '0')
            {
                return true;
            }
            return false;
        }

        public static bool NotCharactersLeftRightMinus(char[][] charMap)
        {
            if (charMap[UpDown][LeftRight - 1] != ':'
                && charMap[UpDown][LeftRight - 1] != 'O'
                && charMap[UpDown][LeftRight - 1] != '0')
            {
                return true;
            }
            return false;
        }

        public static bool NotCharactersUpDownPlus(char[][] charMap)
        {
            if (charMap[UpDown + 1][LeftRight] != '~'
                && charMap[UpDown + 1][LeftRight] != 'O'
                && charMap[UpDown + 1][LeftRight] != '0')
            {
                return true;
            }
            return false;
        }

        public static bool NotCharactersUpDownMinus(char[][] charMap)
        {
            if (charMap[UpDown - 1][LeftRight] != '~'
                && charMap[UpDown - 1][LeftRight] != 'O'
                && charMap[UpDown - 1][LeftRight] != '0')
            {
                return true;
            }
            return false;
        }

        public static bool Characterm(char[][] charMap)
        {
            if (charMap[UpDown - 1][LeftRight] == 'm'
                || charMap[UpDown + 1][LeftRight] == 'm'
                || charMap[UpDown][LeftRight - 1] == 'm'
                || charMap[UpDown][LeftRight + 1] == 'm')
            {
                return true;
            }
            return false;
        }

        public static bool CharacterM(char[][] charMap)
        {
            if (charMap[UpDown - 1][LeftRight] == 'M'
                || charMap[UpDown + 1][LeftRight] == 'M'
                || charMap[UpDown][LeftRight - 1] == 'M'
                || charMap[UpDown][LeftRight + 1] == 'M')
            {
                return true;
            }
            return false;
        }

        public static bool CharacterK(char[][] charMap)
        {
            if (charMap[UpDown - 1][LeftRight] == 'K'
                || charMap[UpDown + 1][LeftRight] == 'K'
                || charMap[UpDown][LeftRight - 1] == 'K'
                || charMap[UpDown][LeftRight + 1] == 'K')
            {
                return true;
            }
            return false;
        }

        public static bool CharacterO(char[][] charMap)
        {
            if (charMap[UpDown - 1][LeftRight] == 'O'
                || charMap[UpDown + 1][LeftRight] == 'O'
                || charMap[UpDown][LeftRight - 1] == 'O'
                || charMap[UpDown][LeftRight + 1] == 'O')
            {
                return true;
            }
            return false;
        }

        public static bool Character0(char[][] charMap)
        {
            if (charMap[UpDown - 1][LeftRight] == '0'
                || charMap[UpDown + 1][LeftRight] == '0'
                || charMap[UpDown][LeftRight - 1] == '0'
                || charMap[UpDown][LeftRight + 1] == '0')
            {
                return true;
            }
            return false;
        }

        public static bool CharacterR(char[][] charMap)
        {
            if (charMap[UpDown - 1][LeftRight] == 'R'
                || charMap[UpDown + 1][LeftRight] == 'R'
                || charMap[UpDown][LeftRight - 1] == 'R'
                || charMap[UpDown][LeftRight + 1] == 'R')
            {
                return true;
            }
            return false;
        }
    }
}
