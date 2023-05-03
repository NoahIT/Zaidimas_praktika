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
using Zaidimas_Pirmoji_Programvimo_Praktika.Models;

namespace Zaidimas_Pirmoji_Programvimo_Praktika
{
    /// <summary>
    /// Interaction logic for AchievmentWindow.xaml
    /// </summary>
    public partial class AchievmentWindow : Window
    {
        public AchievmentWindow()
        {
            InitializeComponent();
            dtgInventory.ItemsSource = PlayingModel.Achievments;
        }

        private void dtgInventory_Loaded(object sender, RoutedEventArgs e)
        {
            dtgInventory.MinWidth = dtgInventory.ActualWidth;
            dtgInventory.MaxWidth = dtgInventory.ActualWidth;
            dtgInventory.MinHeight = dtgInventory.ActualHeight;
            dtgInventory.MaxHeight = dtgInventory.ActualHeight;
        }
    }
}
