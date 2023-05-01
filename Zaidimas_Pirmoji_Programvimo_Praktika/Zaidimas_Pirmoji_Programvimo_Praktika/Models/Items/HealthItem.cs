using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models.Items
{
    public class HealthItem : Item
    {
        public HealthItem(
            string name,
            string desc,
            BitmapImage image,
            decimal price,
            int mana,
            int health)
                    :base(
                         name,
                         desc,
                         image,
                         price,
                         mana)
        {
            Health = health;
        }

        public int Health { get; set; } 
    }
}
