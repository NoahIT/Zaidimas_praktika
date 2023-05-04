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

            var boots1 = new Boots("boots", "desc", new BitmapImage(new Uri("Recourses\\Images\\Items\\boots.png", UriKind.Relative)), 200, 15);
            var sword1 = new Sword("sword", "desc", new BitmapImage(new Uri("Recourses\\Images\\Items\\sword.png", UriKind.Relative)), 250, 30);
            var armor1 = new Armor("armor", "desc", new BitmapImage(new Uri("Recourses\\Images\\Items\\armor.png", UriKind.Relative)), 350, 20);

            var boots2 = new Boots("boots", "desc", new BitmapImage(new Uri("Recourses\\Images\\Items\\boots1.png", UriKind.Relative)), 300, 25);
            var sword2 = new Sword("sword", "desc", new BitmapImage(new Uri("Recourses\\Images\\Items\\sword1.png", UriKind.Relative)), 350, 50);
            var armor2= new Armor("armor", "desc", new BitmapImage(new Uri("Recourses\\Images\\Items\\armor1.png", UriKind.Relative)), 450, 45);

            item1.ImagePath = "Recourses\\Images\\Items\\damage.png";
            item2.ImagePath = "Recourses\\Images\\Items\\health.png";
            item3.ImagePath = "Recourses\\Images\\Items\\mana.png";

            boots1.ImagePath = "Recourses\\Images\\Items\\boots.png";
            sword1.ImagePath = "Recourses\\Images\\Items\\sword.png";
            armor1.ImagePath = "Recourses\\Images\\Items\\armor.png";

            boots2.ImagePath = "Recourses\\Images\\Items\\boots1.png";
            sword2.ImagePath = "Recourses\\Images\\Items\\sword1.png";
            armor2.ImagePath = "Recourses\\Images\\Items\\armor1.png";

            return new List<Item>() { item1, item2, item3, boots1, sword1, armor1, boots2, sword2, armor2 };
        }
    }
}
