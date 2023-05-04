using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models.Items
{
    public class ManaItem : Item
    {
        public ManaItem(string name, string desc, BitmapImage image, decimal price, int mana, int regen) : base(name, desc, image, price, false)
        {
            Mana = mana; Regen = regen; 
        }
        public int Mana { get; }

        public int Regen { get; }
    }
}
