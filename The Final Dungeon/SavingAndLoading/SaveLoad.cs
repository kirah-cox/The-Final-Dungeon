using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MyTools;
using AllCreations;
using LootThings;

namespace SavingAndLoading
{
    public class SaveLoad
    {
        public static string filePath = "C:\\Users\\kirah\\source\\repos\\The-Final-Dungeon\\The Final Dungeon\\SavingAndLoading\\SaveFile.txt";
        public static void Save(Player player)
        {
            string jsonLevelNumber = JsonSerializer.Serialize(Tools.LevelNumber);
            string jsonMapNumber = JsonSerializer.Serialize(Tools.MapNumber);
            string jsonPlayer = JsonSerializer.Serialize(player);
            string jsonWeaponInventory = JsonSerializer.Serialize(player.WeaponInventory);
            string jsonPotionInventory = JsonSerializer.Serialize(player.PotionInventory);


            using (StreamWriter sw = new StreamWriter(filePath))
    	    {
        	    sw.WriteLine(jsonLevelNumber);
        	    sw.WriteLine(jsonMapNumber);
        	    sw.WriteLine(jsonPlayer);
        	    sw.WriteLine(jsonWeaponInventory);
        	    sw.WriteLine(jsonPotionInventory);
    	    }
        }

        public static void Load(StringBuilder sb, Character character)
        {
            string[] loading = File.ReadAllLines(filePath);

            int loadedLevelNumber = JsonSerializer.Deserialize<int>(loading[0]);
            int loadedMapNumber = JsonSerializer.Deserialize<int>(loading[1]);
            var loadedPlayer = JsonSerializer.Deserialize<Player>(loading[2]);
            var loadedWeaponInventory = JsonSerializer.Deserialize<List<Weapons>>(loading[3]);
            var loadedPotionInventory = JsonSerializer.Deserialize<Dictionary<Potions.PotionType, int>>(loading[4]);

            Player player = new Player(loadedPlayer.Class);
            player.Health = loadedPlayer.Health;
            player.Strength = loadedPlayer.Strength;
            player.Mana = loadedPlayer.Mana;
            player.Luck = loadedPlayer.Luck;
            player.Experience = loadedPlayer.Experience;
            player.Level = loadedPlayer.Level;

            Tools.LevelNumber = loadedLevelNumber;
            Tools.MapNumber = loadedMapNumber;

            if (loadedWeaponInventory != null)
            {
                foreach (var weapon in loadedWeaponInventory)
                {
                    player.WeaponInventory.Add(weapon);
                }
            }
            if (loadedPotionInventory != null)
            {
                foreach (var potion in loadedPotionInventory)
                {
                    player.PotionInventory.Add(potion.Key, potion.Value);
                }
            }

            character.UpDown = Tools.UpDownList[Tools.LevelNumber][2 * Tools.MapNumber];
            character.LeftRight = Tools.LeftRightList[Tools.LevelNumber][2 * Tools.MapNumber];

            Console.Clear();

            MainDrawingMap.DrawMainMap(sb, Tools.LevelsList[Tools.LevelNumber][Tools.MapNumber], Tools.ResetLevelsList[Tools.LevelNumber][Tools.MapNumber], character);
        }
    }
}
