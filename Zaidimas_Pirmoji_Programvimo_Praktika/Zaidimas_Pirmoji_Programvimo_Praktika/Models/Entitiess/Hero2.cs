﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Zaidimas_Pirmoji_Programvimo_Praktika.Models.Items;

namespace Zaidimas_Pirmoji_Programvimo_Praktika.Models
{
    public class Hero2 : Entity
    {
        public Hero2() : base(
                            "Hero2",
                            new BitmapImage(new Uri($"Recourses\\Images\\Hero2\\Idle.gif", UriKind.Relative)),
                            50,
                            120,
                            100,
                            null,
                            new List<Achievment>(),
                            1,
                            1,
                            0,
                            100,
                            new List<Item>())
        {

        }
        public void SetToPlayingModel(Hero2 h)
        {
            PlayingModel.Name = h.Name;
            PlayingModel.Image = h.Image;
            PlayingModel.DefaultAttack = h.DefaultAttack;
            PlayingModel.DefaultHealth = h.DefaultHealth;
            PlayingModel.DefaultMana = h.DefaultMana;
            PlayingModel.Inventory = h.Inventory;
            PlayingModel.Achievments = h.Achievments;
            PlayingModel.RoundLvl = h.RoundLvl;
            PlayingModel.PlayerLvl = h.PlayerLvl;
            PlayingModel.Experience = h.Experience;
            PlayingModel.Money = h.Money;
            PlayingModel.HowManyAttackDid = h.HowManyAttackDid;
            PlayingModel.HowManyTimesDied = h.HowManyTimesDied;
            PlayingModel.Equiped = h.Equiped;
        }
    }
}
