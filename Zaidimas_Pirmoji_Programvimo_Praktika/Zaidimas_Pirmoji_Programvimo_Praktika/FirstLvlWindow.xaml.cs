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
using WpfMessageBox = System.Windows.MessageBox;
using System.Diagnostics.Eventing.Reader;

namespace Zaidimas_Pirmoji_Programvimo_Praktika
{
    public partial class FirstLvlWindow : Window
    {
        EntitiesController EController = new EntitiesController();

        public FirstLvlWindow()
        {
            InitializeComponent();
            ImageBehavior.SetAnimatedSource(enemyHero, EnemiesPlayingModel.Image);
            ImageBehavior.SetAnimatedSource(mainHero, PlayingModel.Image);
            EnemyHp.Value = EnemiesPlayingModel.DefaultHealth;
            HeroHp.Value = PlayingModel.DefaultHealth;
            HeroMana.Value = PlayingModel.DefaultMana;
            EnemyMana.Value = EnemiesPlayingModel.DefaultMana;

            DispatcherTimer timer1 = new DispatcherTimer();
            timer1.Interval = TimeSpan.FromSeconds(1);
            timer1.Tick += (s, a) =>
            {
                if (HeroHp.Value <= 0)
                {
                    BitmapImage die = new BitmapImage(new Uri($"Recourses\\Images\\{PlayingModel.Name}\\dead.gif", UriKind.Relative));
                    ImageBehavior.SetAnimatedSource(mainHero, die);
                    if (WpfMessageBox.Show("Jus pralaimejote", "Pranesimas", MessageBoxButton.OK) == MessageBoxResult.OK)
                    {
                        timer1.Stop();
                        var page = new GameLobbyWindow();
                        page.Show();
                        this.Close();
                    }
                }

                if (EnemyHp.Value <= 0)
                {
                    BitmapImage die = new BitmapImage(new Uri($"Recourses\\Images\\{EnemiesPlayingModel.Name}\\dead.gif", UriKind.Relative));
                    ImageBehavior.SetAnimatedSource(enemyHero, die);

                    PlayingModel.RoundLvl = EnemiesPlayingModel.RoundLvl;
                    PlayingModel.Experience += 25;
                    PlayingModel.Money += 150;

                    if (WpfMessageBox.Show("Jus laimejote", "Pranesimas", MessageBoxButton.OK) == MessageBoxResult.OK)
                    {
                                            timer1.Stop();
                        var page = new GameLobbyWindow();
                        page.Show();
                        this.Close();
                    }
                }
            };
            timer1.Start();
        }

        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            Attack(20, 35, "Jums neuztenka manos");
        }

        private void btnAttack2_Click(object sender, RoutedEventArgs e)
        {
            Attack(40, 70, "Jums neuztenka manos");
        }

        private void btnHeal_Click(object sender, RoutedEventArgs e)
        {
            if (PlayingModel.Inventory.FirstOrDefault(x => x.Name == "Health Potion") != null && HeroMana.Value >= 20)
            {
                HeroHp.Value += (HeroHp.Value / 100 * 20);
                HeroMana.Value -= 20;
            }
            else
            {
                MessageBox.Show("Jus neturite tokio potion arba jums neuztenka manos");
            }
        }

        private void btnQuit1_Click(object sender, RoutedEventArgs e)
        {
            var page = new GameLobbyWindow();
            page.Show();
            this.Close();
        }

        private void btnDamagePotion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMana_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Attack(int mana, int damage,string messageBox)
        {
            if (HeroMana.Value >= mana)
            {
                DispatcherTimer timer1 = new DispatcherTimer();
                timer1.Interval = TimeSpan.FromSeconds(1);
                DispatcherTimer timer2 = new DispatcherTimer();
                timer2.Interval = TimeSpan.FromSeconds(2);
                DispatcherTimer timer3 = new DispatcherTimer();
                timer3.Interval = TimeSpan.FromSeconds(3);

                timer1.Tick += (s, a) =>
                {
                    timer1.Stop();

                    EController.AttackHero(damage, EnemyHp, mainHero, PlayingModel.Name);
                    HeroMana.Value -= mana;
                    EController.Hurt(enemyHero, EnemiesPlayingModel.Name);


                    if (EnemyHp.Value > 0)
                    {
                        timer2.Start();
                    }
                    else
                    {
                        timer1.Stop();
                    }
                };

                timer2.Tick += (s2, a2) =>
                {
                    timer2.Stop();
                    if (EnemyHp.Value > 0)
                    {
                         EController.AttackEnemy(EnemiesPlayingModel.DefaultAttack, HeroHp, enemyHero, EnemiesPlayingModel.Name);
                    }
                    else
                    {
                        timer1.Stop();
                        timer3.Start();
                    }
                };

                timer3.Tick += (s, a) =>
                {
                    BitmapImage die = new BitmapImage(new Uri($"Recourses\\Images\\{EnemiesPlayingModel.Name}\\dead.gif", UriKind.Relative));
                    ImageBehavior.SetAnimatedSource(enemyHero, die);
                };

                timer1.Start();
            }
            else
            {
                MessageBox.Show(messageBox);
            }
        }
    }
}
