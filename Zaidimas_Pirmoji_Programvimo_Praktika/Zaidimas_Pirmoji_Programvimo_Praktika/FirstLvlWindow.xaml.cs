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
        }

        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            if (HeroMana.Value >= 20)
            {
                DispatcherTimer timer1 = new DispatcherTimer();
                timer1.Interval = TimeSpan.FromSeconds(1);
                timer1.Tick += (s, a) =>
                {
                    timer1.Stop();
                    EController.AttackHero(30, EnemyHp, mainHero, PlayingModel.Name);
                    HeroMana.Value -= 20;
                    EController.Hurt(enemyHero, EnemiesPlayingModel.Name);

                    if (EnemyHp.Value <= 0)
                    {
                        PlayingModel.RoundLvl++;
                        PlayingModel.Experience += 25;
                        PlayingModel.Money += 150;
                        if (WpfMessageBox.Show("Jus laimejote", "Pranesimas", MessageBoxButton.OK) == MessageBoxResult.OK)
                        {
                            var page = new GameLobbyWindow();
                            page.Show();
                            this.Close();
                        }
                    }

                    DispatcherTimer timer2 = new DispatcherTimer();
                    timer2.Interval = TimeSpan.FromSeconds(2);
                    timer2.Tick += (s2, a2) =>
                    {
                        timer2.Stop();
                        EController.AttackEnemy(EnemiesPlayingModel.DefaultAttack, HeroHp, enemyHero, EnemiesPlayingModel.Name);
                        if (HeroHp.Value <= 0)
                        {
                            if (WpfMessageBox.Show("Jus pralaimejote", "Pranesimas", MessageBoxButton.OK) == MessageBoxResult.OK)
                            {
                                var page = new GameLobbyWindow();
                                page.Show();
                                this.Close();
                            }
                        }
                    };
                    timer2.Start();
                };
                timer1.Start();

                HeroMana.Value += 5;
            }
            else
            {
                MessageBox.Show("Jums neuztenka mana,jei turite naudokite mana potion");
            }
        }

        private void btnAttack2_Click(object sender, RoutedEventArgs e)
        {
            PlayingModel.IsAttacking = true;
            EnemiesPlayingModel.IsAttacking = true;

                if (HeroMana.Value >= 40)
                {
                    
                    DispatcherTimer timer1 = new DispatcherTimer();
                    timer1.Interval = TimeSpan.FromSeconds(1);
                    timer1.Tick += (s, a) =>
                    {
                        timer1.Stop();

                        EController.AttackHero(70, EnemyHp, mainHero, PlayingModel.Name);
                        HeroMana.Value -= 40;
                        EController.Hurt(enemyHero, EnemiesPlayingModel.Name);



                        DispatcherTimer timer2 = new DispatcherTimer();
                        timer2.Interval = TimeSpan.FromSeconds(2);
                        timer2.Tick += (s2, a2) =>
                        {
                            EnemiesPlayingModel.IsAttacking = true;
                            timer2.Stop();
                            EController.AttackEnemy(EnemiesPlayingModel.DefaultAttack, HeroHp, enemyHero, EnemiesPlayingModel.Name);

                        };
                        timer2.Start();
                    };
                    timer1.Start();

                    HeroMana.Value += 5;
                }
                else
                {
                    MessageBox.Show("Jums neuztenka mana,jei turite naudokite mana potion");
                }
                    if (EnemyHp.Value <= 0)
                    {
                        BitmapImage die = new BitmapImage(new Uri($"Recourses\\Images\\{EnemiesPlayingModel.Name}\\dead.gif", UriKind.Relative));
                        ImageBehavior.SetAnimatedSource(enemyHero, die);
                        PlayingModel.RoundLvl++;
                        PlayingModel.Experience += 25;
                        PlayingModel.Money += 150;
                        if (WpfMessageBox.Show("Jus laimejote", "Pranesimas", MessageBoxButton.OK) == MessageBoxResult.OK)
                        {
                            var page = new GameLobbyWindow();
                            page.Show();
                            this.Close();
                        }
                    }

                if (HeroHp.Value <= 0)
                {
                    BitmapImage die = new BitmapImage(new Uri($"Recourses\\Images\\{PlayingModel.Name}\\dead.gif", UriKind.Relative));
                    ImageBehavior.SetAnimatedSource(mainHero,die);
                    if (WpfMessageBox.Show("Jus pralaimejote", "Pranesimas", MessageBoxButton.OK) == MessageBoxResult.OK)
                    {
                        var page = new GameLobbyWindow();
                        page.Show();
                        this.Close();
                    }
                }

            EnemiesPlayingModel.IsAttacking = false;
            PlayingModel.IsAttacking = false;

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
    }
}
