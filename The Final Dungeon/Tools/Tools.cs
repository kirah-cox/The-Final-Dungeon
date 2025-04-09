using AllCreations;
using AllMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootThings;
using System.Security.Cryptography.X509Certificates;

namespace MyTools
{
    public class Tools
    {
        public static bool EncounteredEnemy { get; set; } = false;
        public static bool ChestEmpty { get; set; } = false;
        public static bool ObtainedKey { get; set; } = false;
        public static bool CrossedGap { get; set; } = false;
        public static bool ObtainedFeather { get; set; } = false;
        public static bool PushingBoulder { get; set; } = false;
        public static bool BoulderOverGap { get; set; } = false;
        public static bool ResetRoom { get; set; } = false;
        public static int MapNumber { get; set; } = 0;

        public static void PressEnter()
        {
            Console.WriteLine("Press enter to continue.");

            bool enterPressed = false;
            while (!enterPressed)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    enterPressed = true;
                }
            }
        }
    }
}


