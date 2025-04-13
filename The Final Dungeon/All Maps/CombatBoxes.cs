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

        public static void DrawCombatBox(Player player, Enemy enemy)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(FirstCombatBox[6]).Remove(13, 2).Insert(13, player.Health);
            FirstCombatBox[6] = sb.ToString().ToCharArray();
            sb.Clear();

            if (FirstCombatBox[6].Length < 34)
            {
                sb.Append(FirstCombatBox[6]).Insert(30, ' ');
                FirstCombatBox[6] = sb.ToString().ToCharArray();
                sb.Clear();
            }

            sb.Append(FirstCombatBox[8]).Remove(19, 2).Insert(19, enemy.Health);
            FirstCombatBox[8] = sb.ToString().ToCharArray();
            sb.Clear();

            if (FirstCombatBox[8].Length < 34)
            {
                sb.Append(FirstCombatBox[8]).Insert(30, ' ');
                FirstCombatBox[8] = sb.ToString().ToCharArray();
                sb.Clear();
            }

            foreach (var item in FirstCombatBox)
            {
                Console.WriteLine(item);
            }
        }
    }
}
