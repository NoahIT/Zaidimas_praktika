using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models.Items
{
    public class Sword : Item
    {
        public Sword(
            string name,
            string description,
            BitmapImage image,
            decimal price,
            int Plusattack )
                        : base(
                              name,
                              description,
                              image,
                              price,
                              true) 
        {
            PlusAttack = Plusattack; 
        }
        public int PlusAttack { get; set; }
    }
}
