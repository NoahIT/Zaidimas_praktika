using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models.Items
{
    public class DamageItem : Item
    {
        public DamageItem(
            string name,
            string desc,
            BitmapImage image,
            decimal price,
            int mana,
            int damage)
                    : base(
                          name,
                          desc,
                          image,
                          price,
                          false)
        {
            Mana = mana;
            Damage = damage;
        }
        public int Mana { get; }

        public int Damage { get; } 
    }
}
