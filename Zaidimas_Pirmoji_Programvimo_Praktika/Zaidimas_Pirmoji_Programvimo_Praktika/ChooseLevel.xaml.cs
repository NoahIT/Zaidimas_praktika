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
    /// Interaction logic for ChooseLevel.xaml
    /// </summary>
    public partial class ChooseLevel : Window
    {
        public ChooseLevel()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, RoutedEventArgs e)
        {
            PlayingModel.HardLvl = 1;

            OpenWindow();
        }

        private void btnMedium_Click(object sender, RoutedEventArgs e)
        {
            PlayingModel.HardLvl = 2;

            OpenWindow();
        }

        private void btnHard_Click(object sender, RoutedEventArgs e)
        {
            PlayingModel.HardLvl = 3;

            OpenWindow();
        }

        private void OpenWindow()
        {
            var page = new GameLobbyWindow();
            page.Show();
            this.Close();
        }
    }
}
