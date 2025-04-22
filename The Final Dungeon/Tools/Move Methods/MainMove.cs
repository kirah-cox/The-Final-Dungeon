using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllCreations;
using AllMaps;
using LootThings;
using SavingAndLoading;

namespace MyTools
{
    public class MainMove : Tools
    {
        public static void Move(Player player, char[][] charMap, char[][] charResetMap, StringBuilder sb, Character character)
        {
            character.Up = false;
            character.Down = false;
            character.Left = false;
            character.Right = false;
            CrossingIce = false;
            IceHitSomething = false;
            IceLineNumber = 1;

            var key = Console.ReadKey().Key;
            if (key == ConsoleKey.W && SmallMoveMethods.NotCharactersUpDownMinus(charMap, character))
            {
                MainConsoleKeyMoveMethods.PressedW(charMap, charResetMap, character);
            }
            else if (key == ConsoleKey.S && SmallMoveMethods.NotCharactersUpDownPlus(charMap, character))
            {
                MainConsoleKeyMoveMethods.PressedS(charMap, charResetMap, character);
            }
            else if (key == ConsoleKey.A && SmallMoveMethods.NotCharactersLeftRightMinus(charMap, character))
            {
                MainConsoleKeyMoveMethods.PressedA(charMap, charResetMap, character);
            }
            else if (key == ConsoleKey.D && SmallMoveMethods.NotCharactersLeftRightPlus(charMap, character))
            {
                MainConsoleKeyMoveMethods.PressedD(charMap, charResetMap, character);
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
            else if (key == ConsoleKey.Escape)
            {
                while (true)
                {
                    Console.Clear();

                    Console.WriteLine("1. Save");
                    Console.WriteLine("2. Load");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine("Press enter to continue.");

                    var newKey = Console.ReadKey().Key;

                    if (newKey == ConsoleKey.D1)
                    {
                        if (!BossRoom)
                        {
                            SaveLoad.Save(player);
                            Console.WriteLine("Your game has been saved.");
                            PressEnter();
                        }
                        else if (BossRoom)
                        {
                            Console.WriteLine("You cannot save in this room.");
                        }
                        break;
                    }
                    else if (newKey == ConsoleKey.D2)
                    {
                        Console.WriteLine("Previous save loaded.");
                        Loading = true;
                        PressEnter();
                        SaveLoad.Load(sb, character, out player);
                        break;
                    }
                    else if(newKey == ConsoleKey.D3)
                    {
                        Environment.Exit(0);
                        Console.WriteLine("Exiting the game.");
                        PressEnter();
                        break;
                    }
                    else if (newKey == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }

            MainBattle.RandomEnemyEncounter();
        }
    }
}
