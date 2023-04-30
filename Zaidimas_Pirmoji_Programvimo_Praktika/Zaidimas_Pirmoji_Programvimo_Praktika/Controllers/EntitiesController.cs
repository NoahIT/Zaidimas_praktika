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
            BitmapImage jumpImage = new BitmapImage(new Uri($"Recourses\\Images\\{pathname}\\jump.gif", UriKind.Relative));
            ImageBehavior.SetAnimatedSource(mainHero, jumpImage);

            // Создайте анимацию удара
            BitmapImage kickImage = new BitmapImage(new Uri($"Recourses\\Images\\{pathname}\\attack1.gif", UriKind.Relative));

            var margin = mainHero.Margin;

            // Создайте таймер для задержки перед ударом
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (s, a) =>
            { 

                // Код, который нужно выполнить после задержки
                timer.Stop();

                // Установите источник для mainHero в качестве kickImage
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
                    // Код, который нужно выполнить после возврата в исходное состояние
                    idleTimer.Stop();

                    // Установите источник для mainHero в качестве idleImage
                    ImageBehavior.SetAnimatedSource(mainHero, idleImage);
                    mainHero.Margin = margin;
                };
                idleTimer.Start();
            };

            timer.Start();
        }

        public void Hurt(Image hero,string pathname)
        {
            double photoLeft = Canvas.GetLeft(hero);
            double photoTop = Canvas.GetTop(hero);

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
                    Canvas.SetLeft(hero, photoLeft);
                    Canvas.SetTop(hero, photoTop);
                };
                idleTimer.Start();
            };

            timer.Start();
        }

        internal void AttackEnemy(int damage, ProgressBar heroHp, Image enemyHero, string pathname)
        {
            BitmapImage jumpImage = new BitmapImage(new Uri($"Recourses\\Images\\{pathname}\\jump.gif", UriKind.Relative));
            ImageBehavior.SetAnimatedSource(enemyHero, jumpImage);

            BitmapImage kickImage = new BitmapImage(new Uri($"Recourses\\Images\\{pathname}\\attack1.gif", UriKind.Relative));

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
