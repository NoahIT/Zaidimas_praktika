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
using System.Windows.Media.Animation;
using System.Threading;
using System.Windows.Threading;

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

        public GameLobbyWindow(List<Achievment> ach)
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
            if (ach != null)
            {
                ach.ForEach(item => PlayingModel.Achievments.Add(item));
            }

            ShowElementsForTwoSeconds(rctAch, lblAch);
        }

        private void ShowElementsForTwoSeconds(UIElement element1, UIElement element2)
        {
            element1.Visibility = Visibility.Visible;
            element2.Visibility = Visibility.Visible;

            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Tick += (sender, args) =>
            {
                element1.Visibility = Visibility.Hidden;
                element2.Visibility = Visibility.Hidden;

                MainGrid.Children.Remove(element1);
                MainGrid.Children.Remove(element2);

                timer.Stop();
            };
            timer.Start();
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
                PlayingModel.Achievments,
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

        private void btnLevel6_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.Get6Lvl());

            OpenFightingWindow();
        }

        private void btnLevel7_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.Get7Lvl());

            OpenFightingWindow();
        }

        private void btnLevel8_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.Get8Lvl());

            OpenFightingWindow();
        }

        private void btnLevel9_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.Get9Lvl());

            OpenFightingWindow();
        }

        private void btnLevel10_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.Get10Lvl());

            OpenFightingWindow();
        }

        private void btnLevel11_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.Get11Lvl());

            OpenFightingWindow();
        }

        private void btnLevel12_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.Get12Lvl());

            OpenFightingWindow();
        }

        private void btnLevel13_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.Get13Lvl());

            OpenFightingWindow();
        }

        private void btnLevel14_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.Get14Lvl());

            OpenFightingWindow();
        }

        private void btnLevel15_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.Get15Lvl());

            OpenFightingWindow();
        }

        private void btnLevel16_Click(object sender, RoutedEventArgs e)
        {
            var x = new Enemies();
            x.SetToPlayingModel(x.Get16Lvl());

            OpenFightingWindow();
        }

        private void btnAchiev_Click(object sender, RoutedEventArgs e)
        {
            var page = new AchievmentWindow();
            page.Show();
            this.Close();
        }
    }
}
