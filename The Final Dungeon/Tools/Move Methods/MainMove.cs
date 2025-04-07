using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllCreations;
using AllMaps;
using LootThings;

namespace MyTools
{
    public class MainMove : Tools
    {
        public static void Move(Player player, char[][] charMap, StringBuilder sb, string character)
        {
            Up = false;
            Down = false;
            Left = false;
            Right = false;

            var key = Console.ReadKey().Key;
            if (key == ConsoleKey.W && SmallMoveMethods.NotCharactersUpDownMinus(charMap))
            {
                MainConsoleKeyMoveMethods.PressedW(charMap);
            }
            else if (key == ConsoleKey.S && SmallMoveMethods.NotCharactersUpDownPlus(charMap))
            {
                MainConsoleKeyMoveMethods.PressedS(charMap);
            }
            else if (key == ConsoleKey.A && SmallMoveMethods.NotCharactersLeftRightMinus(charMap))
            {
                MainConsoleKeyMoveMethods.PressedA(charMap);
            }
            else if (key == ConsoleKey.D && SmallMoveMethods.NotCharactersLeftRightPlus(charMap))
            {
                MainConsoleKeyMoveMethods.PressedD(charMap);
            }
            else if (key == ConsoleKey.R)
            {
                Player.DisplayInventory(player);
            }
            else if (key == ConsoleKey.E)
            {
                MainConsoleKeyMoveMethods.PressedE(sb, charMap, player);
            }

            RandomEnemyEncounter();
        }
    }
}
