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
using Zaidimas_Pirmoji_Programvimo_Praktika.Models.Items;
using Zaidimas_Pirmoji_Programvimo_Praktika.Products;

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

            ImageBehavior.SetAnimatedSource(hero, PlayingModel.Image);
            lblAttack.Content = "Attack Damage: " + PlayingModel.DefaultAttack;
            lblHealth.Content = "Hero`s Health" + PlayingModel.DefaultHealth;
            lblLvl.Content = PlayingModel.PlayerLvl + " lvl";
            lblMana.Content = "Hero`s Mana: " + PlayingModel.DefaultMana;
            valueofPrg.Content = PlayingModel.Experience;
            prgExp.Value = PlayingModel.Experience;
            lblMoney.Content = "Money: " + PlayingModel.Money + " Coins";
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
    }
}
