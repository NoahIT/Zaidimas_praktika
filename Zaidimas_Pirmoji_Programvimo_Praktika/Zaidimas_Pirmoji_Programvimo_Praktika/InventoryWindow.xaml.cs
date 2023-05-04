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
    /// Interaction logic for InventoryWindow.xaml
    /// </summary>
    public partial class InventoryWindow : Window
    {

        public InventoryWindow()
        {
            InitializeComponent();
            ImageBehavior.SetAnimatedSource(hero, PlayingModel.Image);
            lblMoney.Content = "Money: " + PlayingModel.Money + " Coins";

            if (PlayingModel.Inventory != null)
            {
                dtgInventory.ItemsSource = PlayingModel.Inventory;
            }
            else
            {
                dtgInventory.IsEnabled = false;
                btnSell.IsEnabled = false;
            }
            dtgEquipped.ItemsSource = PlayingModel.Equiped;

        }

        private void btnSell_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = dtgInventory.SelectedItem as Item;

            if (selectedItem != null)
            {
                PlayingModel.Inventory.Remove(selectedItem);
                PlayingModel.Money += selectedItem.Price;
            }

            lblMoney.Content = "Money:" + PlayingModel.Money + " Coins";

            var page = new InventoryWindow();

            page.Show();

            this.Close();
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

        private void dtgInventory_Loaded(object sender, RoutedEventArgs e)
        {
            dtgInventory.MinWidth = dtgInventory.ActualWidth;
            dtgInventory.MaxWidth = dtgInventory.ActualWidth;
            dtgInventory.MinHeight = dtgInventory.ActualHeight;
            dtgInventory.MaxHeight = dtgInventory.ActualHeight;
        }

        private void btnUnEquip_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = dtgEquipped.SelectedItem as Item;
            if (selectedItem != null)
            {
                selectedItem.IsEquiped = false;
                PlayingModel.Equiped.Remove(selectedItem);
                PlayingModel.Inventory.Add(selectedItem);

                if (selectedItem is Sword sword)
                {
                    PlayingModel.DefaultAttack -= sword.PlusAttack;
                }
                if (selectedItem is Armor armor)
                {
                    PlayingModel.DefaultHealth -= armor.PlusHealth;
                }
                if (selectedItem is Boots boots)
                {
                    PlayingModel.DefaultMana -= boots.PlusMana;
                }

                dtgEquipped.Items.Refresh();
                dtgInventory.Items.Refresh();
            }
        }

        private void btnEquip_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = dtgInventory.SelectedItem as Item;
            if (selectedItem != null)
            {
                if (PlayingModel.Equiped.FirstOrDefault(x=>x.Name == selectedItem.Name) == null)
                {
                    selectedItem.IsEquiped = true;
                    PlayingModel.Inventory.Remove(selectedItem);
                    PlayingModel.Equiped.Add(selectedItem);

                    if (selectedItem is Sword sword)
                    {
                        PlayingModel.DefaultAttack += sword.PlusAttack;
                    }
                    if (selectedItem is Armor armor)
                    {
                        PlayingModel.DefaultHealth += armor.PlusHealth;
                    }
                    if (selectedItem is Boots boots)
                    {
                        PlayingModel.DefaultMana += boots.PlusMana;
                    }

                    dtgEquipped.Items.Refresh();
                    dtgInventory.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Jus jau uzsidejote tokio tipo item");
                }
            }
        }
    }
}
