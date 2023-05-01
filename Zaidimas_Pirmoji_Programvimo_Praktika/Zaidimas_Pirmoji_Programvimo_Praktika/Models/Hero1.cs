using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Zaidimas_Pirmoji_Programvimo_Praktika.Models.Items;
using Zaidimas_Pirmoji_Programvimo_Praktika.Products;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models
{
    public class Hero1 : Entity
    {
        public Hero1() : base(
                            "Ninja",
                            new BitmapImage(new Uri($"Recourses\\Images\\Ninja\\Idle.gif", UriKind.Relative)),
                            58,
                            100,
                            100,
                            new Class1().GetAllItems(),
                            0,
                            1,
                            50,
                            100)
        {
            
        }

        public void SetToPlayingModel(Hero1 h)
        {
            PlayingModel.Name = h.Name;
            PlayingModel.Image = h.Image;
            PlayingModel.DefaultAttack = h.DefaultAttack;
            PlayingModel.DefaultHealth = h.DefaultHealth;
            PlayingModel.DefaultMana = h.DefaultMana;
            PlayingModel.Inventory = h.Inventory;
            PlayingModel.RoundLvl = h.RoundLvl;
            PlayingModel.PlayerLvl = h.PlayerLvl;
            PlayingModel.Experience = h.Experience;
            PlayingModel.Money = h.Money;
        }
    }
}
