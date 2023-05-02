using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models.Items
{
    public class Item
    {
        public Item(
            string name,
            string description,
            BitmapImage image,
            decimal price,
            int mana)
        {
            Name = name;
            Description = description;
            Image = image;
            Price = price;
            Mana = mana;
        }

        public string Name { get; }
        public string Description { get; }
        [JsonIgnore]
        public BitmapImage Image { get; }
        public decimal Price { get; }
        public int Mana { get; }

        public string ImagePath { get; set; }
    }
}
