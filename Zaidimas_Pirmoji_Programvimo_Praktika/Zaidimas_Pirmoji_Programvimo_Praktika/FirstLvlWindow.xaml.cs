using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml;
using WpfAnimatedGif;
using Zaidimas_Pirmoji_Programvimo_Praktika.Models;
using Zaidimas_Pirmoji_Programvimo_Praktika.Properties;
using System.Windows.Controls;
using System.Threading;
using Zaidimas_Pirmoji_Programvimo_Praktika.Controllers;

namespace Zaidimas_Pirmoji_Programvimo_Praktika
{
    public partial class FirstLvlWindow : Window
    {
        EntitiesController EController = new EntitiesController();

        public FirstLvlWindow()
        {
            InitializeComponent();
        }

        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer1 = new DispatcherTimer();
            timer1.Interval = TimeSpan.FromSeconds(1);
            timer1.Tick +=  (s, a) =>
            {
                timer1.Stop();
                EController.AttackHero(20, EnemyHp, mainHero, "Ninja");
                EController.Hurt(enemyHero, "1lvl");

                DispatcherTimer timer2 = new DispatcherTimer();
                timer2.Interval = TimeSpan.FromSeconds(2);
                timer2.Tick += (s2, a2) =>
                {
                    timer2.Stop();
                    EController.AttackEnemy(20, HeroHp, enemyHero, "1lvl");
                };
                timer2.Start();
            };
            timer1.Start();
        }
    }
}
