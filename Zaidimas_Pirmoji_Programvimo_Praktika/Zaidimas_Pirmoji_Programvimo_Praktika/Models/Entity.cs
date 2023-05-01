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
            int roundLvl,
            int playerLvl,
            int experience,
            decimal money)
        {
            Name = name;
            Image = image;
            DefaultAttack = defaultAttack;
            DefaultHealth = defaultHealth;
            DefaultMana = defaultMana;
            Inventory = inventory;
            RoundLvl = roundLvl;
            PlayerLvl = playerLvl;
            Experience = experience;
            Money = money;
        }

        public string Name { get; }
        public BitmapImage Image { get; }
        public int DefaultAttack { get; }
        public int DefaultHealth { get; }
        public int DefaultMana { get; }
        public List<Item> Inventory { get; }
        public int RoundLvl { get; }
        public int PlayerLvl { get; }
        public int Experience { get; }
        public decimal Money { get; }
    }
}
