﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models
{
    public class Entity
    {
        public int posX { get; }
        public int posY { get; }

        public int idleFrames { get; }
        public int runFrames { get; }
        public int attackFrames { get; }
        public int deathFrames { get; }

        public int size { get; }

        public Bitmap spriteSheet { get; }

        public Entity(int posX, int posY, int idleFrames, int runFrames, int attackFrames, int deathFrames, Bitmap spriteSheet)
        {
            this.posX = posX;
            this.posY = posY;
            this.idleFrames = idleFrames;
            this.runFrames = runFrames;
            this.attackFrames = attackFrames;
            this.deathFrames = deathFrames;
            this.spriteSheet = spriteSheet;
            size = 50;
        }

        public void Move()
        {

        }
    }
}
