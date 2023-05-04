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
                30 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                2,
                1,
                1,
                0,
                null
                );
        }

        public Entity GetSecondLvl()
        {
            return new Entity(
                "2lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\2lvl\\Idle.gif", UriKind.Relative)),
                40 * PlayingModel.HardLvl,
                100* PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                3,
                1,
                1,
                0,
                null
                );
        }

        public Entity GetThirdLvl()
        {
            return new Entity(
                "3lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\3lvl\\Idle.gif", UriKind.Relative)),
                40 * PlayingModel.HardLvl,
                120 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                4,
                1,
                1,
                0,
                null
                );
        }

        public Entity GetFourLvl()
        {
            return new Entity(
                "4lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\4lvl\\Idle.gif", UriKind.Relative)),
                50 * PlayingModel.HardLvl,
                150 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                5,
                1,
                1,
                0,
                null
                );
        }

        public Entity GetFiveLvl()
        {
            return new Entity(
                "5lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\5lvl\\Idle.gif", UriKind.Relative)),
                60 * PlayingModel.HardLvl,
                150 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                6,
                1,
                1,
                0,
                null
                );
        }

        public Entity Get6Lvl()
        {
            return new Entity(
                "6lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\6lvl\\Idle.gif", UriKind.Relative)),
                60 * PlayingModel.HardLvl,
                180 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                7,
                1,
                1,
                0,
                null
                );
        }

        public Entity Get7Lvl()
        {
            return new Entity(
                "7lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\7lvl\\Idle.gif", UriKind.Relative)),
                70 * PlayingModel.HardLvl,
                150 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                8,
                1,
                1,
                0,
                null
                );
        }

        public Entity Get8Lvl()
        {
            return new Entity(
                "8lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\8lvl\\Idle.gif", UriKind.Relative)),
                70 * PlayingModel.HardLvl,
                200 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                9,
                1,
                1,
                0,
                null
                );
        }

        public Entity Get9Lvl()
        {
            return new Entity(
                "9lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\9lvl\\Idle.gif", UriKind.Relative)),
                80 * PlayingModel.HardLvl,
                200 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                10,
                1,
                1,
                0,
                null
                );
        }
        public Entity Get10Lvl()
        {
            return new Entity(
                "10lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\10lvl\\Idle.gif", UriKind.Relative)),
                20 * PlayingModel.HardLvl,
                1000 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                11,
                1,
                1,
                0,
                null
                );
        }

        public Entity Get11Lvl()
        {
            return new Entity(
                "11lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\11lvl\\Idle.gif", UriKind.Relative)),
                90 * PlayingModel.HardLvl,
                300 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                12,
                1,
                1,
                0,
                null
                );
        }

        public Entity Get12Lvl()
        {
            return new Entity(
                "12lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\12lvl\\Idle.gif", UriKind.Relative)),
                90 * PlayingModel.HardLvl,
                320 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                13,
                1,
                1,
                0,
                null
                );
        }

        public Entity Get13Lvl()
        {
            return new Entity(
                "13lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\13lvl\\Idle.gif", UriKind.Relative)),
                100 * PlayingModel.HardLvl,
                480 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                14,
                1,
                1,
                0,
                null
                );
        }

        public Entity Get14Lvl()
        {
            return new Entity(
                "14lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\14lvl\\Idle.gif", UriKind.Relative)),
                110 * PlayingModel.HardLvl,
                500 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                15,
                1,
                1,
                0,
                null
                );
        }

        public Entity Get15Lvl()
        {
            return new Entity(
                "15lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\15lvl\\Idle.gif", UriKind.Relative)),
                110 * PlayingModel.HardLvl,
                700 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                16,
                1,
                1,
                0,
                null
                );
        }

        public Entity Get16Lvl()
        {
            return new Entity(
                "16lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\16lvl\\Idle.gif", UriKind.Relative)),
                100 * PlayingModel.HardLvl,
                1000 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                17,
                1,
                1,
                0,
                null
                );
        }

        public Entity Get17Lvl()
        {
            return new Entity(
                "17lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\17lvl\\Idle.gif", UriKind.Relative)),
                110 * PlayingModel.HardLvl,
                1000 * PlayingModel.HardLvl,
                110 * PlayingModel.HardLvl,
                null,
                null,
                18,
                1,
                1,
                0,
                null
                );
        }

        public Entity Get18Lvl()
        {
            return new Entity(
                "18lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\18lvl\\Idle.gif", UriKind.Relative)),
                100 * PlayingModel.HardLvl,
                1000 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                19,
                1,
                1,
                0,
                null
                );
        }

        public Entity Get19Lvl()
        {
            return new Entity(
                "19lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\19lvl\\Idle.gif", UriKind.Relative)),
                100 * PlayingModel.HardLvl,
                1000 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                20,
                1,
                1,
                0,
                null
                );
        }
        public Entity Get20Lvl()
        {
            return new Entity(
                "20lvl",
                new BitmapImage(new Uri($"Recourses\\Images\\20lvl\\Idle.gif", UriKind.Relative)),
                100 * PlayingModel.HardLvl,
                1000 * PlayingModel.HardLvl,
                100 * PlayingModel.HardLvl,
                null,
                null,
                20,
                1,
                1,
                0,
                null
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
            EnemiesPlayingModel.Achievments = h.Achievments;
            EnemiesPlayingModel.RoundLvl = h.RoundLvl;
            EnemiesPlayingModel.PlayerLvl = h.PlayerLvl;
            EnemiesPlayingModel.Experience = h.Experience;
            EnemiesPlayingModel.Money = h.Money;
        }
    }
}
