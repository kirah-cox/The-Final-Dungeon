using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllCreations;
using MyTools;

namespace AllMaps
{
    public class CombatBoxes
    {
        public static char[][] FirstCombatBox =
        {
            "                                  ".ToCharArray(),
            "                                  ".ToCharArray(),
            "                                  ".ToCharArray(),
            "                                  ".ToCharArray(),
            "                                  ".ToCharArray(),
            "                                  ".ToCharArray(),
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            ": :~~~~~~~~~~~:  :~~~~~~~~~~~~~: :".ToCharArray(),
            ": : 1. Attack :  : 2. Use Item : :".ToCharArray(),
            ": :~~~~~~~~~~~:  :~~~~~~~~~~~~~: :".ToCharArray(),
            ":                                :".ToCharArray(),
            ":                                :".ToCharArray(),
            ":    Health:                     :".ToCharArray(),
            ":                                :".ToCharArray(),
            ":    Enemy Health:               :".ToCharArray(),
            ":                                :".ToCharArray(),
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
        };

        public static char[][] FirstLevelBossCombatBox =
        {
            "              _'^'_               ".ToCharArray(),
            "             (0'-'0)              ".ToCharArray(),
            "          _ (   -   ) _           ".ToCharArray(),
            "        (  )(       )(  )         ".ToCharArray(),
            "         ( ) ) | | ( ( )          ".ToCharArray(),
            "        oO)  oO) (Oo  (Oo         ".ToCharArray(),
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
            ": :~~~~~~~~~~~:  :~~~~~~~~~~~~~: :".ToCharArray(),
            ": : 1. Attack :  : 2. Use Item : :".ToCharArray(),
            ": :~~~~~~~~~~~:  :~~~~~~~~~~~~~: :".ToCharArray(),
            ":                                :".ToCharArray(),
            ":                                :".ToCharArray(),
            ":    Health:                     :".ToCharArray(),
            ":                                :".ToCharArray(),
            ":    Enemy Health:               :".ToCharArray(),
            ":                                :".ToCharArray(),
            ":~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~:".ToCharArray(),
        };

        public static void DrawCombatBox (Player player, Enemy enemy, char[][] charMap)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(charMap[12]).Remove(13, 2).Insert(13, player.Health);
            charMap[12] = sb.ToString().ToCharArray();
            sb.Clear();

            if (charMap[12].Length < 34)
            {
                sb.Append(charMap[12]).Insert(30, ' ');
                charMap[12] = sb.ToString().ToCharArray();
                sb.Clear();
            }

            sb.Append(charMap[14]).Remove(19, 2).Insert(19, enemy.Health);
            charMap[14] = sb.ToString().ToCharArray();
            sb.Clear();

            if (charMap[14].Length < 34)
            {
                sb.Append(charMap[14]).Insert(30, ' ');
                charMap[14] = sb.ToString().ToCharArray();
                sb.Clear();
            }

            foreach (var item in charMap)
            {
                Console.WriteLine(item);
            }
        }
    }
}
