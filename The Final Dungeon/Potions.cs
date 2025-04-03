using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class Potions
    {
        public int HealthGained {  get; set; }
        public int StrengthGained {  get; set; }
        public int ManaGained {  get; set; }
        public int LuckGained {  get; set; }
        public PotionType Potion {  get; set; }

        public enum PotionType
        {
            None,
            Health,
            Strength,
            Mana,
            Luck,
        }

        public Potions(PotionType potionType)
        {
            switch (potionType)
            {
                case PotionType.Health:
                    Potion = PotionType.Health;
                    HealthGained = 25;
                    StrengthGained = 0;
                    ManaGained = 0;
                    LuckGained = 0;
                    break;
                case PotionType.Strength:
                    Potion = PotionType.Strength;
                    HealthGained = 0;
                    StrengthGained = 10;
                    ManaGained = 0;
                    LuckGained = 0;
                    break;
                case PotionType.Mana:
                    Potion = PotionType.Mana;
                    HealthGained = 0;
                    StrengthGained = 0;
                    ManaGained = 10;
                    LuckGained = 0;
                    break;
                case PotionType.Luck:
                    Potion = PotionType.Luck;
                    HealthGained = 25;
                    StrengthGained = 0;
                    ManaGained = 0;
                    LuckGained = 10;
                    break;
            }
        }

        public static PotionType RandomPotionType()
        {
            Random randomPotion = new Random();
            int typeOfPotion = randomPotion.Next(1, 5);

            PotionType potion = PotionType.None;

            switch (typeOfPotion)
            {
                case 1:
                    potion = PotionType.Health;
                    break;
                case 2:
                    potion = PotionType.Strength;
                    break;
                case 3:
                    potion = PotionType.Mana;
                    break;
                case 4:
                    potion = PotionType.Luck;
                    break;
                default:
                    break;
            }

            return potion;
        }

        public static int RandomPotionAmount()
        {
            Random randomAmount = new Random();
            int potionAmount = randomAmount.Next(1, 3);

            return potionAmount;
        }
    }
}
