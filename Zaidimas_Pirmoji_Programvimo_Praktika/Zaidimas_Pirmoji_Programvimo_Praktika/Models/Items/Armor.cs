using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models.Items
{
    public class Armor : Item
    {
        public Armor(string name,
            string description,
            BitmapImage image,
            decimal price,
            int Plushealth
                        ) : base(name,description,image,price, true)
        {
            PlusHealth = Plushealth;
        }
        public int PlusHealth { get; set; }
    }
}
