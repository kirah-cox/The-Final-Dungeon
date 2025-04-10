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
    public class InteractMoveMethods : MainMove
    {
        public static void PotionsChestFull(Player player)
        {
            Chest.AddPotion(player);
            FirstLevelMaps.LevelOneChests[MapNumber] = true;
        }

        public static void PotionsChestEmpty()
        {
            Console.Clear();
            Console.WriteLine("The chest is empty.");
            PressEnter();
        }

        public static void MovingToNextRoom(StringBuilder sb, char[][] charMap, Character character)
        {
            SmallMoveMethods.ClearCharacterOnMap(sb, charMap, character);

            MapNumber++;
            character.UpDown = FirstLevelMaps.LevelOneUpDown[2 * MapNumber];
            character.LeftRight = FirstLevelMaps.LevelOneLeftRight[2 * MapNumber];
        }

        public static void MovingToPreviousRoom(StringBuilder sb, char[][] charMap, Character character)
        {
            SmallMoveMethods.ClearCharacterOnMap(sb, charMap, character);

            MapNumber--;
            if (MapNumber == 0)
            {
                character.UpDown = FirstLevelMaps.LevelOneUpDown[1];
                character.LeftRight = FirstLevelMaps.LevelOneLeftRight[1];
            }
            else
            {
                character.UpDown = FirstLevelMaps.LevelOneUpDown[2 * MapNumber + 1];
                character.LeftRight = FirstLevelMaps.LevelOneLeftRight[2 * MapNumber + 1];
            }
        }

        public static void ObtainingKey(StringBuilder sb, char[][] charMap, Character character)
        {
            Console.Clear();
            Console.WriteLine("You have obtained a key.");
            PressEnter();

            sb.Append(charMap[character.UpDown]).Replace('K', '.');
            charMap[character.UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            sb.Append(charMap[character.UpDown + 1]).Replace('K', '.');
            charMap[character.UpDown + 1] = sb.ToString().ToCharArray();
            sb.Clear();
            sb.Append(charMap[character.UpDown - 1]).Replace('K', '.');
            charMap[character.UpDown - 1] = sb.ToString().ToCharArray();
            sb.Clear();

            ObtainedKey = true;
        }

        public static void ObtainingFeather()
        {
            Console.Clear();
            Console.WriteLine("You have obtained the magical feather! You can now jump over small gaps.");
            PressEnter();
            Console.Clear();
            ObtainedFeather = true;
        }

        public static void ResetBoulders()
        {
            ResetRoom = true;
        }
    }
}
