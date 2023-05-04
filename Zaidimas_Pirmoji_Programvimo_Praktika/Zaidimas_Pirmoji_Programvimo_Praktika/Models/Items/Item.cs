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
            bool isEquiping)
        {
            Name = name;
            Description = description;
            Image = image;
            Price = price;
            IsEquiping = isEquiping;
        }

        public string Name { get; }
        public string Description { get; }
        [JsonIgnore]
        public BitmapImage Image { get; set; }
        public decimal Price { get; }

        public string ImagePath { get; set; }
        public bool IsEquiping { get; set; }
        public bool IsEquiped { get; set; }=false;
    }
}
