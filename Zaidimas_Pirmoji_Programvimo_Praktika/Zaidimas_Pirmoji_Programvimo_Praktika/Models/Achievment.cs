using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models
{
    public class Achievment
    {
        public Achievment(BitmapImage image, string name)
        {
            Image = image;
            Name = name;
            ImagePath = Image.UriSource.ToString();
        }
        [JsonIgnore]
        public BitmapImage Image { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }

    }
}
