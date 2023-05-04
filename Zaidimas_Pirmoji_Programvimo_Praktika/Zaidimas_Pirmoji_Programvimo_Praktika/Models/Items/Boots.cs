using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models.Items
{
    public class Boots : Item
    {
        public Boots(string name, string description, BitmapImage image, decimal price, int Plusmana) : base(name, description, image, price, true) 
        {
            PlusMana = Plusmana; 
        }
        public int PlusMana { get; set; }
    }
}
