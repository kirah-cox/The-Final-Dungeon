using AllMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools;

class Tools
{
    public static int UpDown { get; set; } = 1;
    public static int LeftRight { get; set; } = 1;
    public static bool Up { get; set; } = false;
    public static bool Down { get; set; } = false;
    public static bool Left { get; set; } = false;
    public static bool Right { get; set; } = false;

    public static void Move()
    {
        Up = false;
        Down = false;
        Left = false;
        Right = false;

        var key = Console.ReadKey().Key;
        if (key == ConsoleKey.W && UpDown > 1)
        {
            UpDown--;
            Up = true;
            Console.Clear();
        }
        else if (key == ConsoleKey.S && UpDown < 9)
        {
            UpDown++;
            Down = true;
            Console.Clear();
        }
        else if (key == ConsoleKey.A && LeftRight > 1)
        {
            LeftRight--;
            Left = true;
            Console.Clear();
        }
        else if (key == ConsoleKey.D && LeftRight < 31)
        {
            LeftRight++;
            Right = true;
            Console.Clear();
        }
    }

    public static void DrawMap(StringBuilder sb, Map map, string character)
    {
        Console.SetCursorPosition(0, 0);
        Console.CursorVisible = false;

        CharacterMovesUpOrDown(sb, map, character);

        if (Up)
        {
            CharacterMovesUpOrDown(sb, map, character);
            ClearAfterMovingUp(sb, map, character);
        }
        else if (Down)
        {
            CharacterMovesUpOrDown(sb, map, character);
            ClearAfterMovingDown(sb, map, character);
        }
        else if (Left)
        {
            MoveAndClearLeft(sb, map, character);
        }
        else if (Right)
        {
            MoveAndClearRight(sb, map, character);
        }

        foreach (var item in map.FirstMap)
        {
            Console.WriteLine(item);
        }
    }

    public static void CharacterMovesUpOrDown(StringBuilder sb, Map map, string character)
    {
        sb.Append(map.FirstMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character);
        map.FirstMap[UpDown] = sb.ToString().ToCharArray();
        sb.Clear();
    }

    public static void ClearAfterMovingUp(StringBuilder sb, Map map, string character)
    {
        sb.Append(map.FirstMap[UpDown + 1]).Remove(LeftRight, 1).Insert(LeftRight, " ");
        map.FirstMap[UpDown + 1] = sb.ToString().ToCharArray();
        sb.Clear();
    }

    public static void ClearAfterMovingDown(StringBuilder sb, Map map, string character)
    {
        sb.Append(map.FirstMap[UpDown - 1]).Remove(LeftRight, 1).Insert(LeftRight, " ");
        map.FirstMap[UpDown - 1] = sb.ToString().ToCharArray();
        sb.Clear();
    }

    public static void MoveAndClearLeft(StringBuilder sb, Map map, string character)
    {
        sb.Append(map.FirstMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character).Remove(LeftRight + 1, 1).Insert(LeftRight + 1, " ");
        map.FirstMap[UpDown] = sb.ToString().ToCharArray();
        sb.Clear();
    }

    public static void MoveAndClearRight(StringBuilder sb, Map map, string character)
    {
        sb.Append(map.FirstMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character).Remove(LeftRight - 1, 1).Insert(LeftRight - 1, " ");
        map.FirstMap[UpDown] = sb.ToString().ToCharArray();
        sb.Clear();
    }
}
