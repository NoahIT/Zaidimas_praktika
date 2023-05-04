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
    /// Interaction logic for ChooseHeroWindow.xaml
    /// </summary>
    public partial class ChooseHeroWindow : Window
    {
        public ChooseHeroWindow()
        {
            InitializeComponent();
        }

        private void btnNinja_Click(object sender, RoutedEventArgs e)
        {
            var x = new Hero1();
            x.SetToPlayingModel(x);

            openWindow();
        }

        private void btnVampire_Click(object sender, RoutedEventArgs e)
        {
            var x = new Hero3();
            x.SetToPlayingModel(x);

            openWindow();
        }

        private void btnGirl_Click(object sender, RoutedEventArgs e)
        {
            var x = new Hero2();
            x.SetToPlayingModel(x);

            openWindow();
        }

        public void openWindow()
        {
            var page = new ChooseLevel();

            page.Show();

            this.Close();
        }
    }
}
