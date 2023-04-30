using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models
{
    public class Hero : Entity
    {
        public Hero(
            int posX,
            int posY,
            int idleFrames,
            int runFrames,
            int attackFrames,
            int deathFrames,
            Bitmap spriteSheet)
                        :
                        base(posX,
                            posY,
                            idleFrames,
                            runFrames,
                            attackFrames,
                            deathFrames,
                            spriteSheet)
        {
            
        }
    }
}
