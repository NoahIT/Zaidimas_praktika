using System;
using System.Windows;

namespace Zaidimas_Pirmoji_Programvimo_Praktika
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            var ChooseAccountWindow = new ChooseAccountWindow();
            ChooseAccountWindow.Show();
            this.Close();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var page = new FirstLvlWindow();

            page.Show();

            this.Close();
        }
    }
}
