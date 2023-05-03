using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Zaidimas_Pirmoji_Programvimo_Praktika.Models;
using Zaidimas_Pirmoji_Programvimo_Praktika.Models.Items;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Products
{
    public class CreatedItems
    {
        public List<Item> GetAllItems()
        {
            var item1 = new DamageItem("Damage Potion", "desc", new BitmapImage(new Uri("Recourses\\Images\\Items\\damage.png", UriKind.Relative)), 100, 30, 25);
            var item2 = new HealthItem("Health Potion", "desc", new BitmapImage(new Uri("Recourses\\Images\\Items\\health.png", UriKind.Relative)), 20, 20, 50);
            var item3 = new ManaItem("Mana Potion", "desc", new BitmapImage(new Uri("Recourses\\Images\\Items\\mana.png", UriKind.Relative)), 100, 10, 45);

            item1.ImagePath = "Recourses\\Images\\Items\\damage.png";
            item2.ImagePath = "Recourses\\Images\\Items\\health.png";
            item3.ImagePath = "Recourses\\Images\\Items\\mana.png";

            return new List<Item>() { item1, item2, item3 };
        }
    }
}
