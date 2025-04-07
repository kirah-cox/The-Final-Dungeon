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
    public class InteractMoveMethods : MainMove
    {
        public static void PotionsChestFull(Player player)
        {
            Chest.AddPotion(player);
            Map.LevelOneChests[MapNumber] = true;
        }

        public static void PotionsChestEmpty()
        {
            Console.Clear();
            Console.WriteLine("The chest is empty.");
            PressEnter();
        }

        public static void MovingToNextRoom(StringBuilder sb, char[][] charMap)
        {
            SmallMoveMethods.ClearCharacterOnMap(sb, charMap);

            MapNumber++;
            UpDown = Map.LevelOneUpDown[2 * MapNumber];
            LeftRight = Map.LevelOneLeftRight[2 * MapNumber];
        }

        public static void MovingToPreviousRoom(StringBuilder sb, char[][] charMap)
        {
            SmallMoveMethods.ClearCharacterOnMap(sb, charMap);

            MapNumber--;
            if (MapNumber == 0)
            {
                UpDown = Map.LevelOneUpDown[1];
                LeftRight = Map.LevelOneLeftRight[1];
            }
            else
            {
                UpDown = Map.LevelOneUpDown[2 * MapNumber + 1];
                LeftRight = Map.LevelOneLeftRight[2 * MapNumber + 1];
            }
        }

        public static void ObtainingKey(StringBuilder sb, char[][] charMap)
        {
            Console.Clear();
            Console.WriteLine("You have obtained a key.");
            PressEnter();

            sb.Append(charMap[UpDown]).Replace('K', '.');
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            sb.Append(charMap[UpDown + 1]).Replace('K', '.');
            charMap[UpDown + 1] = sb.ToString().ToCharArray();
            sb.Clear();
            sb.Append(charMap[UpDown - 1]).Replace('K', '.');
            charMap[UpDown - 1] = sb.ToString().ToCharArray();
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
    }
}
