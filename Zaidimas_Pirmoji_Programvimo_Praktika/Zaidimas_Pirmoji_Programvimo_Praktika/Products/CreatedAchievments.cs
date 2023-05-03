using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaidimas_Pirmoji_Programvimo_Praktika.Models;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Products
{
    public class CreatedAchievments
    {
        public Achievment Get1Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\1.png", UriKind.Relative)),"Did 10 attack");
        }
        
        public Achievment Get2Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\2.png", UriKind.Relative)),"Died 10 times");
        }
        
        public Achievment Get3Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\3.png", UriKind.Relative)),"First Boss");
        }
        
        public Achievment Get4Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\4.png", UriKind.Relative)),"Second Boss");
        }
        
        public Achievment Get5Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\5.png", UriKind.Relative)),"Veteran");
        }
        
        public Achievment Get6Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\6.png", UriKind.Relative)),"Did 20 attack");
        }
        
        public Achievment Get7Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\7.png", UriKind.Relative)),"Did 30 attack");
        }
        
        public Achievment Get8Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\8.png", UriKind.Relative)),"Did 50 attack");
        }
        
        public Achievment Get9Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\9.png", UriKind.Relative)),"Died 20 times");
        }
        
        public Achievment Get10Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\10.png", UriKind.Relative)),"Died 5 times");
        }
    }
}
