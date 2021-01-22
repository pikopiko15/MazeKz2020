﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebMaze.Models
{
    public class GwentViewModel
    {
        public enum Faction
        {
            Monsters = 0,
            Northern_Realms = 1,
            ScoiaTael = 2,
            Skellige = 3,
            Nilfgaard = 4,
            Neutral = 5

        }

        public string CardTitle { get; set; }
        public int CardStrenght { get; set; }
        public string CardUrl { get; set; }
        public string CardAbility { get; set; }
        public string CardDescription { get; set; }
        public Faction CardFaction {private get; set; }
        public string DisplayFaction => CardFaction.ToString();

    }
}
