using AllCreations;
using AllMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootThings;

namespace MyTools;

class Tools
{
    public static int UpDown { get; set; } = 1;
    public static int LeftRight { get; set; } = 1;
    public static bool Up { get; set; } = false;
    public static bool Down { get; set; } = false;
    public static bool Left { get; set; } = false;
    public static bool Right { get; set; } = false;
    public static bool EncounteredEnemy { get; set; } = false;

    
    public static PlayerClass MenuScreen()
    {
        while (true)
        {
            Console.WriteLine("Welcome to The Final Dungeon. Press WASD to move, E to interact, X to access inventory, and Z to access stats.");
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

            var key = Console.ReadKey().Key;

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

    public static void Move(Player player, Map map, char[][] charMap)
    {
        Up = false;
        Down = false;
        Left = false;
        Right = false;

        var key = Console.ReadKey().Key;
        if (key == ConsoleKey.W && charMap[UpDown - 1][LeftRight] == ' ')
        {
            UpDown--;
            Up = true;
            Console.Clear();
        }
        else if (key == ConsoleKey.S && charMap[UpDown + 1][LeftRight] == ' ')
        {
            UpDown++;
            Down = true;
            Console.Clear();
        }
        else if (key == ConsoleKey.A && charMap[UpDown][LeftRight - 1] == ' ')
        {
            LeftRight--;
            Left = true;
            Console.Clear();
        }
        else if (key == ConsoleKey.D && charMap[UpDown][LeftRight + 1] == ' ')
        {
            LeftRight++;
            Right = true;
            Console.Clear();
        }
        else if (key == ConsoleKey.X)
        {
            Player.DisplayInventory(player);
        }

        Random random = new Random();
        int potentialEnemy = random.Next(1, 101);

        if (potentialEnemy <= 5)
        {
            EncounteredEnemy = true;
        }
    }

    public static void DrawMainMap(StringBuilder sb, Map map, char[][] charMap, string character)
    {
        Console.SetCursorPosition(0, 0);
        Console.CursorVisible = false;

        CharacterMovesUpOrDown(sb, map, charMap, character);

        if (Up)
        {
            CharacterMovesUpOrDown(sb, map, charMap, character);
            ClearAfterMovingUp(sb, map, charMap, character);
        }
        else if (Down)
        {
            CharacterMovesUpOrDown(sb, map, charMap, character);
            ClearAfterMovingDown(sb, map, charMap, character);
        }
        else if (Left)
        {
            MoveAndClearLeft(sb, map, charMap, character);
        }
        else if (Right)
        {
            MoveAndClearRight(sb, map, charMap, character);
        }

        foreach (var item in charMap)
        {
            Console.WriteLine(item);
        }
    }

    public static void CharacterMovesUpOrDown(StringBuilder sb, Map map, char[][] charMap, string character)
    {
        sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character);
        charMap[UpDown] = sb.ToString().ToCharArray();
        sb.Clear();
    }

    public static void ClearAfterMovingUp(StringBuilder sb, Map map, char[][] charMap, string character)
    {
        sb.Append(charMap[UpDown + 1]).Remove(LeftRight, 1).Insert(LeftRight, " ");
        charMap[UpDown + 1] = sb.ToString().ToCharArray();
        sb.Clear();
    }

    public static void ClearAfterMovingDown(StringBuilder sb, Map map, char[][] charMap, string character)
    {
        sb.Append(charMap[UpDown - 1]).Remove(LeftRight, 1).Insert(LeftRight, " ");
        charMap[UpDown - 1] = sb.ToString().ToCharArray();
        sb.Clear();
    }

    public static void MoveAndClearLeft(StringBuilder sb, Map map, char[][] charMap, string character)
    {
        sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character).Remove(LeftRight + 1, 1).Insert(LeftRight + 1, " ");
        charMap[UpDown] = sb.ToString().ToCharArray();
        sb.Clear();
    }

    public static void MoveAndClearRight(StringBuilder sb, Map map, char[][] charMap, string character)
    {
        sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character).Remove(LeftRight - 1, 1).Insert(LeftRight - 1, " ");
        charMap[UpDown] = sb.ToString().ToCharArray();
        sb.Clear();
    }

    // FIX!!!!
    public static void Battle(Player player, Enemy enemy)
    {
        while (enemy.Health > 0 && player.Health > 0)
        {
            
            bool correctKey = false;
            while (!correctKey)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"You have encountered {enemy.Class}.");
                Thread.Sleep(2000);
                Console.WriteLine("1: Attack");
                Console.WriteLine("2: Use Item");

                var key = Console.ReadKey().Key;

                if (key == ConsoleKey.D1)
                {
                    Console.WriteLine($"You attacked {enemy.Class} with a damage of {player.Attack()}.");
                    Thread.Sleep(2000);
                    enemy.TakeDamage(player.Attack());
                    correctKey = true;
                }
                else if (key == ConsoleKey.D2)
                {
                    Console.WriteLine("bleh");
                    correctKey = true;
                }

            }

            if (enemy.Health > 0)
            {
                Console.WriteLine($"{enemy.Class} attacks you with a damage of {enemy.Attack()}.");
                Thread.Sleep(2000);
                player.TakeDamage(enemy.Attack());
            }
        }

        if (player.Health <= 0)
        {
            Console.WriteLine("You have died.");
            Environment.Exit(0);
        }

        player.GainExperience(enemy.Experience);
        Console.WriteLine($"You have defeated {enemy.Class} and have gained {enemy.Experience} experience.");
        Console.WriteLine("Press enter to continue.");

        bool enterPressed = false;
        while (!enterPressed)
        {
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                enterPressed = true;
            }
        }

        Console.Clear();
    }
}
