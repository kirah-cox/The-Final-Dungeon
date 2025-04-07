using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class SmallConsoleKeyMoveMethods : MainConsoleKeyMoveMethods
    {
        public static void WNormalMove()
        {
            UpDown--;
            Up = true;
            PushingBoulder = false;
            Console.Clear();
        }

        public static void SNormalMove()
        {
            UpDown++;
            Down = true;
            PushingBoulder = false;
            Console.Clear();
        }

        public static void ANormalMove()
        {
            LeftRight--;
            Left = true;
            PushingBoulder = false;
            Console.Clear();
        }

        public static void DNormalMove()
        {
            LeftRight++;
            Right = true;
            PushingBoulder = false;
            Console.Clear();
        }

        public static void WPushingBoulder(char[][] charMap)
        {
            if (charMap[UpDown - 2][LeftRight] == '.')
            {
                SmallMoveMethods.WBoulderNoGap();
            }
            else if (charMap[UpDown - 2][LeftRight] == ' ')
            {
                SmallMoveMethods.WBoulderGap();
            }
        }

        public static void SPushingBoulder(char[][] charMap)
        {
            if (charMap[UpDown + 2][LeftRight] == '.')
            {
                SmallMoveMethods.SBoulderNoGap();
            }
            else if (charMap[UpDown + 2][LeftRight] == ' ')
            {
                SmallMoveMethods.SBoulderGap();
            }
        }

        public static void APushingBoulder(char[][] charMap)
        {
            if (charMap[UpDown][LeftRight - 2] == '.')
            {
                SmallMoveMethods.ABoulderNoGap();
            }
            else if (charMap[UpDown][LeftRight - 2] == ' ')
            {
                SmallMoveMethods.ABoulderGap();
            }
        }

        public static void DPushingBoulder(char[][] charMap)
        {
            if (charMap[UpDown][LeftRight + 2] == '.')
            {
                SmallMoveMethods.DBoulderNoGap();
            }
            else if (charMap[UpDown][LeftRight + 2] == ' ')
            {
                SmallMoveMethods.DBoulderGap();
            }
        }

        public static void WCrossingGap()
        {
            UpDown -= 2;
            Up = true;
            CrossedGap = true;
            Console.Clear();
        }

        public static void SCrossingGap()
        {
            UpDown += 2;
            Down = true;
            CrossedGap = true;
            Console.Clear();
        }

        public static void ACrossingGap()
        {
            LeftRight -= 2;
            Left = true;
            CrossedGap = true;
            Console.Clear();
        }
        
        public static void DCrossingGap()
        {
            LeftRight += 2;
            Right = true;
            CrossedGap = true;
            Console.Clear();
        }
    }
}
