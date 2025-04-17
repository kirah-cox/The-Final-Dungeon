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

        public static void WCrossingIce(Character character)
        {
            character.UpDown--;
            character.Up = true;
            Console.Clear();
        }

        public static void SCrossingIce(Character character)
        {
            character.UpDown++;
            character.Down = true;
            Console.Clear();
        }

        public static void ACrossingIce(Character character)
        {
            character.LeftRight--;
            character.Left = true;
            Console.Clear();
        }
        public static void DCrossingIce(Character character)
        {
            character.LeftRight++;
            character.Right = true;
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
            else if (charMap[character.UpDown - 2][character.LeftRight] == 'x')
            {
                if (!BoulderOverButton.ContainsKey(character.LeftRight))
                {
                    BoulderOverButton.Add(character.LeftRight, character.UpDown - 2);
                }
                SmallMoveMethods.WBoulderNoGap(character);
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
            else if (charMap[character.UpDown + 2][character.LeftRight] == 'x')
            {
                if (!BoulderOverButton.ContainsKey(character.LeftRight))
                {
                    BoulderOverButton.Add(character.LeftRight, character.UpDown + 2);
                }
                SmallMoveMethods.SBoulderNoGap(character);
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
            else if (charMap[character.UpDown][character.LeftRight - 2] == 'x')
            {
                if (!BoulderOverButton.ContainsKey(character.LeftRight - 2))
                {
                    BoulderOverButton.Add(character.LeftRight - 2, character.UpDown);
                }
                SmallMoveMethods.ABoulderNoGap(character);
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
            else if (charMap[character.UpDown][character.LeftRight + 2] == 'x')
            {
                if (!BoulderOverButton.ContainsKey(character.LeftRight + 2))
                {
                    BoulderOverButton.Add(character.LeftRight + 2, character.UpDown);
                }
                SmallMoveMethods.DBoulderNoGap(character);
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
