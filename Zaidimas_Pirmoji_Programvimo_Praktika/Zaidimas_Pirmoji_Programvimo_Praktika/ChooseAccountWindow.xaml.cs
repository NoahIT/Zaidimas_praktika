using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAnimatedGif;
using Zaidimas_Pirmoji_Programvimo_Praktika.Models;
using System.IO;

namespace Zaidimas_Pirmoji_Programvimo_Praktika
{
    public partial class ChooseAccountWindow : Window
    {
        public ChooseAccountWindow()
        {
            InitializeComponent();
        }

        private void btnAccountSelect1_Click(object sender, RoutedEventArgs e)
        {
            var page = new ChooseHeroWindow();
            page.Show();
            this.Close();
        }

        private void btnLoadGame_Click(object sender, RoutedEventArgs e)
        {
            string json = File.ReadAllText("saves.json");
            Entity entity = JsonConvert.DeserializeObject<Entity>(json);

            BitmapImage image = new BitmapImage(new Uri(entity.ImagePath, UriKind.RelativeOrAbsolute));

            if (entity.Inventory != null)
            {
                entity.Inventory.ForEach(x => x.Image = new BitmapImage(new Uri(x.ImagePath, UriKind.RelativeOrAbsolute)));
            }
            if (entity.Achievments != null)
            {
                entity.Achievments.ForEach(x => x.Image = new BitmapImage(new Uri(x.ImagePath, UriKind.RelativeOrAbsolute)));
            }
            if (entity.Equiped != null)
            {
                entity.Equiped.ForEach(x => x.Image = new BitmapImage(new Uri(x.ImagePath, UriKind.RelativeOrAbsolute)));
            }

            entity.Image = image;

            entity.SetToPlayingModel(entity);

            var page = new GameLobbyWindow();

            page.Show();

            this.Close();
        }

    }
}
