using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Zaidimas_Pirmoji_Programvimo_Praktika.Models.Items;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models
{
    public static class PlayingModel
    {
        public static string Name { get; set; }
        public static BitmapImage Image { get; set; }
        public static int DefaultAttack { get; set; }
        public static int DefaultHealth { get; set; }
        public static int DefaultMana { get; set; }
        public static List<Item> Inventory { get; set; }
        public static int RoundLvl { get; set; }
        public static int PlayerLvl { get; set; }
        public static int Experience { get; set; }
        public static decimal Money { get; set; }
        public static bool IsAttacking { get; set; } = false;
        
    }
}
