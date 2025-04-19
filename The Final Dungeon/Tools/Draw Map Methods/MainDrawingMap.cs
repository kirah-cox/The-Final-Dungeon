using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllCreations;

namespace MyTools
{
    public class MainDrawingMap : Tools
    {
        public static PlayerClass MenuScreen()
        {
            while (true)
            {
                Console.WriteLine("Welcome to The Final Dungeon. Press WASD to move, E to interact, R to access inventory, and T to access stats.");
                Console.WriteLine("What class do you select?");
                Console.WriteLine("1: Warrior");
                Console.WriteLine("     Strength:   5");
                Console.WriteLine("     Mana:       1");
                Console.WriteLine("     Luck:       1");
                Console.WriteLine("2: Wizard");
                Console.WriteLine("     Strength:   1");
                Console.WriteLine("     Mana:       5");
                Console.WriteLine("     Luck:       1");
                Console.WriteLine("3: Rogue");
                Console.WriteLine("     Strength:   1");
                Console.WriteLine("     Mana:       1");
                Console.WriteLine("     Luck:       5");

                var key = Console.ReadKey(intercept: true).Key;

                if (key == ConsoleKey.D1)
                {
                    return PlayerClass.Warrior;
                }
                else if (key == ConsoleKey.D2)
                {
                    return PlayerClass.Wizard;
                }
                else if (key == ConsoleKey.D3)
                {
                    return PlayerClass.Rogue;
                }

                Console.Clear();
            }
        }
        
        public static void DrawMainMap(StringBuilder sb, char[][] charMap, char[][] charResetMap, Character character)
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;

            if (ResetRoom || BossDefeated)
            {
                for (int i = 0; i < 11; i++)
                {
                    charMap[i] = charResetMap[i];
                }
                ResetRoom = false;
            }

            int boulderButtonsRemaining = 0;
            for (int i = 0; i < 11; i++)
            {
                if (charMap[i].Contains('x'))
                {
                    boulderButtonsRemaining++;
                }
            }

            if (boulderButtonsRemaining == 0)
            {
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 33; j++)
                    {
                        if (charMap[i][j] == '#')
                        {
                            charMap[i][j] = '0';
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 33; j++)
                    {
                        if (charMap[i][j] == '0')
                        {
                            charMap[i][j] = '#';
                        }
                    }
                }
            }

            int pressButtonsRemaining = 0;
            for (int i = 0; i < 11; i++)
            {
                if (charMap[i].Contains('X'))
                {
                    pressButtonsRemaining++;
                }
            }

            if (pressButtonsRemaining == 0)
            {
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 33; j++)
                    {
                        if (charMap[i][j] == '#')
                        {
                            charMap[i][j] = '0';
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 33; j++)
                    {
                        if (charMap[i][j] == '0')
                        {
                            charMap[i][j] = '#';
                        }
                    }
                }
            }

            DrawingMapMethods.CharacterMovesUpOrDown(sb, charMap, character);

            if (character.Up)
            {
                DrawingMapMethods.CharacterMovesUpOrDown(sb, charMap, character);
                DrawingMapMethods.ClearAfterMovingUp(sb, charMap, character);
            }
            else if (character.Down)
            {
                DrawingMapMethods.CharacterMovesUpOrDown(sb, charMap, character);
                DrawingMapMethods.ClearAfterMovingDown(sb, charMap, character);
            }
            else if (character.Left)
            {
                DrawingMapMethods.MoveAndClearLeft(sb, charMap, character);
            }
            else if (character.Right)
            {
                DrawingMapMethods.MoveAndClearRight(sb, charMap, character);
            }

            foreach (var item in charMap)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Press WASD to move.");
            Console.WriteLine("Press E to interact.");
            Console.WriteLine("Press R to access inventory.");
            Console.WriteLine("Press T to access stats.");
        }
    }
}
