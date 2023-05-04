using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaidimas_Pirmoji_Programvimo_Praktika.Models;
using Zaidimas_Pirmoji_Programvimo_Praktika.Properties;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Products
{
    public class CreatedAchievments
    {
        public Achievment Get1Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\1.png", UriKind.Relative)),"Did 10 attack", "Recourses\\Images\\achievments\\1.png");
        }
        
        public Achievment Get2Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\2.png", UriKind.Relative)),"Died 10 times", "Recourses\\Images\\achievments\\2.png");
        }
        
        public Achievment Get3Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\3.png", UriKind.Relative)),"First Boss", "Recourses\\Images\\achievments\\3.png");
        }
        
        public Achievment Get4Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\4.png", UriKind.Relative)),"Second Boss", "Recourses\\Images\\achievments\\4.png");
        }
        
        public Achievment Get5Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\5.png", UriKind.Relative)),"Veteran", "Recourses\\Images\\achievments\\5.png");
        }
        
        public Achievment Get6Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\6.png", UriKind.Relative)),"Did 20 attack", "Recourses\\Images\\achievments\\6.png");
        }
        
        public Achievment Get7Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\7.png", UriKind.Relative)),"Did 30 attack", "Recourses\\Images\\achievments\\7.png");
        }
        
        public Achievment Get8Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\8.png", UriKind.Relative)),"Did 50 attack", "Recourses\\Images\\achievments\\8.png");
        }
        
        public Achievment Get9Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\9.png", UriKind.Relative)),"Died 20 times", "Recourses\\Images\\achievments\\9.png");
        }
        
        public Achievment Get10Ach()
        {
            return new Achievment(new System.Windows.Media.Imaging.BitmapImage(new Uri("Recourses\\Images\\achievments\\10.png", UriKind.Relative)),"Died 5 times", "Recourses\\Images\\achievments\\10.png");
        }
    }
}
