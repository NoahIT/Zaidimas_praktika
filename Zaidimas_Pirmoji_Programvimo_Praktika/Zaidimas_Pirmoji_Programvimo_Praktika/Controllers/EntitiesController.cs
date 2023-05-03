using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Threading;
using WpfAnimatedGif;
using Zaidimas_Pirmoji_Programvimo_Praktika.Models;
using System.Windows.Controls;
using System.Windows;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Controllers
{
    public class EntitiesController
    {
        public void AttackHero(int attackDamage, ProgressBar enemyHp, Image mainHero,string pathname)
        {
            if (!PlayingModel.IsAttacking || !EnemiesPlayingModel.IsAttacking)
            {
                BitmapImage jumpImage = new BitmapImage(new Uri($"Recourses\\Images\\{pathname}\\jump.gif", UriKind.Relative));
                ImageBehavior.SetAnimatedSource(mainHero, jumpImage);

                BitmapImage kickImage = new BitmapImage(new Uri($"Recourses\\Images\\{pathname}\\attack.gif", UriKind.Relative));

                var margin = mainHero.Margin;

                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += (s, a) =>
                { 

                    timer.Stop();

                    mainHero.HorizontalAlignment = HorizontalAlignment.Left;
                    mainHero.VerticalAlignment = VerticalAlignment.Top;
                    mainHero.Margin = new Thickness(200, 50, 0 , 0);

                    ImageBehavior.SetAnimatedSource(mainHero, kickImage);
                    enemyHp.Value -= attackDamage;

                    // Создайте анимацию возврата в исходное состояние
                    BitmapImage idleImage = new BitmapImage(new Uri($"Recourses\\Images\\{pathname}\\Idle.gif", UriKind.Relative));
                    DispatcherTimer idleTimer = new DispatcherTimer();
                    idleTimer.Interval = TimeSpan.FromSeconds(1);
                    idleTimer.Tick += (s2, a2) =>
                    {
                        idleTimer.Stop();

                        ImageBehavior.SetAnimatedSource(mainHero, idleImage);
                        mainHero.Margin = margin;
                    };
                    idleTimer.Start();
                };

                timer.Start();
            }

        }

        public void Hurt(Image hero,string pathname)
        {
            var margin = hero.Margin;

            BitmapImage kickImage = new BitmapImage(new Uri($"Recourses\\Images\\{pathname}\\hurt.gif", UriKind.Relative));

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (s, a) =>
            {
                timer.Stop();

                ImageBehavior.SetAnimatedSource(hero, kickImage);

                BitmapImage idleImage = new BitmapImage(new Uri($"Recourses\\Images\\{pathname}\\Idle.gif", UriKind.Relative));
                DispatcherTimer idleTimer = new DispatcherTimer();
                idleTimer.Interval = TimeSpan.FromSeconds(1);
                idleTimer.Tick += (s2, a2) =>
                {
                    idleTimer.Stop();

                    ImageBehavior.SetAnimatedSource(hero, idleImage);
                    hero.Margin = margin;
                };
                idleTimer.Start();
            };

            timer.Start();
        }

        public void AttackEnemy(int damage, ProgressBar heroHp, Image enemyHero, string pathname)
        {
            if (!PlayingModel.IsAttacking || !EnemiesPlayingModel.IsAttacking)
            {
                BitmapImage jumpImage = new BitmapImage(new Uri($"Recourses\\Images\\{pathname}\\jump.gif", UriKind.Relative));
                ImageBehavior.SetAnimatedSource(enemyHero, jumpImage);

                BitmapImage kickImage = new BitmapImage(new Uri($"Recourses\\Images\\{pathname}\\attack.gif", UriKind.Relative));

                var margin = enemyHero.Margin;

                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += (s, a) =>
                {
                    timer.Stop();

                    enemyHero.HorizontalAlignment = HorizontalAlignment.Left;
                    enemyHero.VerticalAlignment = VerticalAlignment.Top;
                    enemyHero.Margin = new Thickness(60, 80, 0, 0);

                    ImageBehavior.SetAnimatedSource(enemyHero, kickImage);
                    heroHp.Value -= damage;

                    BitmapImage idleImage = new BitmapImage(new Uri($"Recourses\\Images\\{pathname}\\Idle.gif", UriKind.Relative));
                    DispatcherTimer idleTimer = new DispatcherTimer();
                    idleTimer.Interval = TimeSpan.FromSeconds(1);
                    idleTimer.Tick += (s2, a2) =>
                    {
                        idleTimer.Stop();

                        ImageBehavior.SetAnimatedSource(enemyHero, idleImage);
                        enemyHero.Margin = margin;
                    };
                    idleTimer.Start();
                };

                timer.Start();
            }
        }
    }
}
