using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models
{
    public class Enemies
    {
        public Entity GetFirstLvl()
        {
            return new Entity(
                "1lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\1lvl\\Idle.gif", UriKind.Relative)),
                100,
                100,
                100,
                null,
                1,
                1,
                1,
                0
                );
        }

        public Entity GetSecondLvl()
        {
            return new Entity(
                "2lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\Ninja\\Idle.gif", UriKind.Relative)),
                20,
                100,
                100,
                null,
                1,
                1,
                1,
                0
                );
        }

        public Entity GetThirdLvl()
        {
            return new Entity(
                "3lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\Ninja\\Idle.gif", UriKind.Relative)),
                30,
                100,
                100,
                null,
                1,
                1,
                1,
                0
                );
        }

        public Entity GetFourLvl()
        {
            return new Entity(
                "4lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\Ninja\\Idle.gif", UriKind.Relative)),
                40,
                100,
                100,
                null,
                1,
                1,
                1,
                0
                );
        }

        public Entity GetFiveLvl()
        {
            return new Entity(
                "5lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\Ninja\\Idle.gif", UriKind.Relative)),
                50,
                200,
                100,
                null,
                1,
                1,
                1,
                0
                );
        }

        public void SetToPlayingModel(Entity h)
        {
            EnemiesPlayingModel.Name = h.Name;
            EnemiesPlayingModel.Image = h.Image;
            EnemiesPlayingModel.DefaultAttack = h.DefaultAttack;
            EnemiesPlayingModel.DefaultHealth = h.DefaultHealth;
            EnemiesPlayingModel.DefaultMana = h.DefaultMana;
            EnemiesPlayingModel.Inventory = h.Inventory;
            EnemiesPlayingModel.RoundLvl = h.RoundLvl;
            EnemiesPlayingModel.PlayerLvl = h.PlayerLvl;
            EnemiesPlayingModel.Experience = h.Experience;
            EnemiesPlayingModel.Money = h.Money;
        }
    }
}
