﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Zaidimas_Pirmoji_Programvimo_Praktika.Models.Items;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models
{
    public class Hero3 : Entity
    {
        public Hero3() : base(
                            "Hero3",
                            new BitmapImage(new Uri($"Recourses\\Images\\Hero3\\Idle.gif", UriKind.Relative)),
                            58,
                            100,
                            100,
                            null,
                            0,
                            1,
                            0,
                            100)
        {

        }

        public void SetToPlayingModel(Hero3 h)
        {
            PlayingModel.Name = h.Name;
            PlayingModel.Image = h.Image;
            PlayingModel.DefaultAttack = h.DefaultAttack;
            PlayingModel.DefaultHealth = h.DefaultHealth;
            PlayingModel.DefaultMana = h.DefaultMana;
            PlayingModel.Inventory = h.Inventory;
            PlayingModel.RoundLvl = h.RoundLvl;
            PlayingModel.PlayerLvl = h.PlayerLvl;
            PlayingModel.Experience = h.Experience;
            PlayingModel.Money = h.Money;
        }
    }
}
