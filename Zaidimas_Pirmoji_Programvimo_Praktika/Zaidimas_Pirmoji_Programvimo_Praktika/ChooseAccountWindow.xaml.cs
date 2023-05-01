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
            // logika del save/load turi but
            var page = new ChooseHeroWindow();
            page.Show();
            this.Close();
        }

        private void btnAccountSelect2_Click(object sender, RoutedEventArgs e)
        {
            // logika del save/load turi but
            var page = new ChooseHeroWindow();
            page.Show();
            this.Close();
        }

        private void btnAccountSelect3_Click(object sender, RoutedEventArgs e)
        {
            // logika del save/load turi but
            var page = new ChooseHeroWindow();
            page.Show();
            this.Close();
        }
    }
}
