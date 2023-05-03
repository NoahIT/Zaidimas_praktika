using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Linq;
using System.Xml;
using WpfAnimatedGif;
using Zaidimas_Pirmoji_Programvimo_Praktika.Models;
using Zaidimas_Pirmoji_Programvimo_Praktika.Models.Items;
using Zaidimas_Pirmoji_Programvimo_Praktika.Products;
using Newtonsoft.Json;

namespace Zaidimas_Pirmoji_Programvimo_Praktika
{
    /// <summary>
    /// Interaction logic for GameLobbyWindow.xaml
    /// </summary>
    public partial class GameLobbyWindow : Window
    {
        public GameLobbyWindow()
        {
            InitializeComponent();

            if (PlayingModel.Experience > 100)
            {
                PlayingModel.PlayerLvl++;
                PlayingModel.Experience -= 100;
                prgExp.Value = PlayingModel.Experience;
                valueofPrg.Content = PlayingModel.Experience;
                lblLvl.Content = PlayingModel.PlayerLvl + " lvl";
            }

            ImageBehavior.SetAnimatedSource(hero, PlayingModel.Image);
            lblAttack.Content = "Attack Damage: " + PlayingModel.DefaultAttack;
            lblHealth.Content = "Hero`s Health: " + PlayingModel.DefaultHealth;
            lblMana.Content = "Hero`s Mana: " + PlayingModel.DefaultMana;
            lblMoney.Content = "Money: " + PlayingModel.Money + " Coins";

            List<Button> buttoms = new List<Button>
            {
                btnLevel1, btnLevel2, btnLevel3, btnLevel4, btnLevel5, btnLevel6, btnLevel7, btnLevel8, btnLevel9, btnLevel10,
                btnLevel11, btnLevel12, btnLevel13, btnLevel14, btnLevel15, btnLevel16, btnLevel17, btnLevel18, btnLevel19, btnLevel20
            };

            foreach (var item in buttoms)
            {
                item.IsEnabled = true;
                if (item.Name == "btnLevel" + PlayingModel.RoundLvl.ToString())
                {
                    item.IsEnabled = true;
                    elpCurr.Margin = item.Margin;
                    break;
                }
            }
        }

        private void btnInventory_Click(object sender, RoutedEventArgs e)
        {
            var page = new InventoryWindow();

            page.Show();

            this.Close();
        }

        private void btnShop_Click(object sender, RoutedEventArgs e)
        {
            var page = new ShopWindow();

            page.Show();

            this.Close();
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            var page = new GameLobbyWindow();

            page.Show();

            this.Close();
        }

        private void btnLevel1_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.GetFirstLvl());

            OpenFightingWindow();
        }

        public void OpenFightingWindow()
        {
            var page = new FirstLvlWindow();

            page.Show();

            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var x = new Entity(
                PlayingModel.Name,
                PlayingModel.Image,
                PlayingModel.DefaultAttack,
                PlayingModel.DefaultHealth,
                PlayingModel.DefaultMana,
                PlayingModel.Inventory,
                PlayingModel.RoundLvl,
                PlayingModel.PlayerLvl,
                PlayingModel.Experience,
                PlayingModel.Money);

            x.ImagePath = $"Recourses/Images/{PlayingModel.Name}/Idle.gif";

            string json = JsonConvert.SerializeObject(x, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText("saves.json", json);
        }

        private void btnLevel2_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.GetSecondLvl());

            OpenFightingWindow();
        }

        private void btnLevel3_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.GetThirdLvl());

            OpenFightingWindow();
        }

        private void btnLevel4_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.GetFourLvl());

            OpenFightingWindow();
        }

        private void btnLevel5_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.GetFiveLvl());

            OpenFightingWindow();
        }
    }
}
