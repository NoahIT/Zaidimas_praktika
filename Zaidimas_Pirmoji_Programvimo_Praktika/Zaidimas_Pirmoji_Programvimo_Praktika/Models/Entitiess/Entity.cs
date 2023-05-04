using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Zaidimas_Pirmoji_Programvimo_Praktika.Models.Items;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models
{
    public class Entity
    {
        public Entity(
            string name,
            BitmapImage image,
            int defaultAttack,
            int defaultHealth,
            int defaultMana,
            List<Item> inventory,
            List<Achievment> achievments,
            int roundLvl,
            int playerLvl,
            int experience,
            decimal money,
            List<Item> equiped)
        {
            Name = name;
            Image = image;
            DefaultAttack = defaultAttack;
            DefaultHealth = defaultHealth;
            DefaultMana = defaultMana;
            Inventory = inventory;
            Achievments = achievments;
            RoundLvl = roundLvl;
            PlayerLvl = playerLvl;
            Experience = experience;
            Money = money;
            Equiped = equiped;
            HardLvl = 1;
        }


        [JsonConstructor]
        public Entity(
                string name,
                BitmapImage image,
                int defaultAttack,
                int defaultHealth,
                int defaultMana,
                List<Item> inventory,
                List<Achievment> achievments,
                int roundLvl,
                int playerLvl,
                int experience,
                decimal money,
                List<Item> equiped,
                int hardLvl)
        {
            Name = name;
            Image = image;
            DefaultAttack = defaultAttack;
            DefaultHealth = defaultHealth;
            DefaultMana = defaultMana;
            Inventory = inventory;
            Achievments = achievments;
            RoundLvl = roundLvl;
            PlayerLvl = playerLvl;
            Experience = experience;
            Money = money;
            Equiped = equiped;
            HardLvl = hardLvl;
        }

        public string Name { get; }
        [JsonIgnore]
        public BitmapImage Image { get; set; }
        public int DefaultAttack { get; }
        public int DefaultHealth { get; }
        public int DefaultMana { get; }
        public List<Item> Inventory { get; }
        public List<Achievment> Achievments { get; set; }
        public int RoundLvl { get; }
        public int PlayerLvl { get; }
        public int Experience { get; }
        public decimal Money { get; }
        public string ImagePath { get; set; }
        public int HowManyTimesDied { get; set; } = 0;
        public int HowManyAttackDid { get; set; } = 0;
        public List<Item> Equiped { get; set; }
        public int HardLvl { get; set; }

        public void SetToPlayingModel(Entity h)
        {
            PlayingModel.Name = h.Name;
            PlayingModel.Image = h.Image;
            PlayingModel.DefaultAttack = h.DefaultAttack;
            PlayingModel.DefaultHealth = h.DefaultHealth;
            PlayingModel.DefaultMana = h.DefaultMana;
            PlayingModel.Inventory = h.Inventory;
            PlayingModel.Achievments = h.Achievments;
            PlayingModel.RoundLvl = h.RoundLvl;
            PlayingModel.PlayerLvl = h.PlayerLvl;
            PlayingModel.Experience = h.Experience;
            PlayingModel.Money = h.Money;
            PlayingModel.HowManyAttackDid = h.HowManyAttackDid;
            PlayingModel.HowManyTimesDied = h.HowManyTimesDied;
            PlayingModel.Equiped = h.Equiped;
            PlayingModel.HardLvl = h.HardLvl;
        }
    }
}
