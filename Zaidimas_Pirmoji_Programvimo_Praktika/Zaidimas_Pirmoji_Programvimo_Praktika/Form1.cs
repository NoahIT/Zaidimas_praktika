using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zaidimas_Pirmoji_Programvimo_Praktika.Models;

namespace Zaidimas_Pirmoji_Programvimo_Praktika
{
    public partial class Form1 : Form
    {
        public Bitmap drawSheet;
        public Entity player;
        public int k=0;

        public Form1()
        {
            InitializeComponent();
            Init();
            timer1.Enabled = true;
        }

        public void Init()
        {

        }

        private void OnPaint(object sender, PaintEventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            k++;
            if (k == 0)
                pictureBox1.Image = Image.FromFile("Recourses\\Images\\Ninja\\idle\\Idle_1.png");
            if (k == 1)
                pictureBox1.Image = Image.FromFile("Recourses\\Images\\Ninja\\idle\\Idle_2.png");
            if (k == 2)
                pictureBox1.Image = Image.FromFile("Recourses\\Images\\Ninja\\idle\\Idle_3.png");
            if (k == 3)
                pictureBox1.Image = Image.FromFile("Recourses\\Images\\Ninja\\idle\\Idle_4.png");
            if (k == 4)
                pictureBox1.Image = Image.FromFile("Recourses\\Images\\Ninja\\idle\\Idle_5.png");
            if (k == 5)
                pictureBox1.Image = Image.FromFile("Recourses\\Images\\Ninja\\idle\\Idle_6.png");
            if (k == 6)
                pictureBox1.Image = Image.FromFile("Recourses\\Images\\Ninja\\idle\\Idle_7.png");
            if (k == 7) 
            {
                pictureBox1.Image = Image.FromFile("Recourses\\Images\\Ninja\\idle\\Idle_8.png");
                k = 0; 
            }

            
        }
    }
}
