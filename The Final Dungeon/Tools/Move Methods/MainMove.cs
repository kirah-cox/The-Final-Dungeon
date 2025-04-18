﻿using System;
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
        public static void Move(Player player, char[][] charMap, StringBuilder sb, Character character)
        {
            character.Up = false;
            character.Down = false;
            character.Left = false;
            character.Right = false;
            CrossingIce = false;
            IceLineNumber = 1;

            var key = Console.ReadKey().Key;
            if (key == ConsoleKey.W && SmallMoveMethods.NotCharactersUpDownMinus(charMap, character))
            {
                MainConsoleKeyMoveMethods.PressedW(charMap, character);
            }
            else if (key == ConsoleKey.S && SmallMoveMethods.NotCharactersUpDownPlus(charMap, character))
            {
                MainConsoleKeyMoveMethods.PressedS(charMap, character);
            }
            else if (key == ConsoleKey.A && SmallMoveMethods.NotCharactersLeftRightMinus(charMap, character))
            {
                MainConsoleKeyMoveMethods.PressedA(charMap, character);
            }
            else if (key == ConsoleKey.D && SmallMoveMethods.NotCharactersLeftRightPlus(charMap, character))
            {
                MainConsoleKeyMoveMethods.PressedD(charMap, character);
            }
            else if (key == ConsoleKey.R)
            {
                Player.DisplayInventory(player);
            }
            else if (key == ConsoleKey.T)
            {
                player.DisplayStats();
            }
            else if (key == ConsoleKey.E)
            {
                MainConsoleKeyMoveMethods.PressedE(sb, charMap, player, character);
            }

            MainBattle.RandomEnemyEncounter();
        }
    }
}
