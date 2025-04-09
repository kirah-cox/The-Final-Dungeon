using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class SmallConsoleKeyMoveMethods : MainConsoleKeyMoveMethods
    {
        public static void WNormalMove(Character character)
        {
            character.UpDown--;
            character.Up = true;
            PushingBoulder = false;
            Console.Clear();
        }

        public static void SNormalMove(Character character)
        {
            character.UpDown++;
            character.Down = true;
            PushingBoulder = false;
            Console.Clear();
        }

        public static void ANormalMove(Character character)
        {
            character.LeftRight--;
            character.Left = true;
            PushingBoulder = false;
            Console.Clear();
        }

        public static void DNormalMove(Character character)
        {
            character.LeftRight++;
            character.Right = true;
            PushingBoulder = false;
            Console.Clear();
        }

        public static void WPushingBoulder(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown - 2][character.LeftRight] == '.')
            {
                SmallMoveMethods.WBoulderNoGap(character);
            }
            else if (charMap[character.UpDown - 2][character.LeftRight] == ' ')
            {
                SmallMoveMethods.WBoulderGap(character);
            }
        }

        public static void SPushingBoulder(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown + 2][character.LeftRight] == '.')
            {
                SmallMoveMethods.SBoulderNoGap(character);
            }
            else if (charMap[character.UpDown + 2][character.LeftRight] == ' ')
            {
                SmallMoveMethods.SBoulderGap(character);
            }
        }

        public static void APushingBoulder(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown][character.LeftRight - 2] == '.')
            {
                SmallMoveMethods.ABoulderNoGap(character);
            }
            else if (charMap[character.UpDown][character.LeftRight - 2] == ' ')
            {
                SmallMoveMethods.ABoulderGap(character);
            }
        }

        public static void DPushingBoulder(char[][] charMap, Character character)
        {
            if (charMap[character.UpDown][character.LeftRight + 2] == '.')
            {
                SmallMoveMethods.DBoulderNoGap(character);
            }
            else if (charMap[character.UpDown][character.LeftRight + 2] == ' ')
            {
                SmallMoveMethods.DBoulderGap(character);
            }
        }

        public static void WCrossingGap(Character character)
        {
            character.UpDown -= 2;
            character.Up = true;
            CrossedGap = true;
            Console.Clear();
        }

        public static void SCrossingGap(Character character)
        {
            character.UpDown += 2;
            character.Down = true;
            CrossedGap = true;
            Console.Clear();
        }

        public static void ACrossingGap(Character character)
        {
            character.LeftRight -= 2;
            character.Left = true;
            CrossedGap = true;
            Console.Clear();
        }
        
        public static void DCrossingGap(Character character)
        {
            character.LeftRight += 2;
            character.Right = true;
            CrossedGap = true;
            Console.Clear();
        }
    }
}
