﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Cage : Environment
    {
        public string Biome { get; }
        public bool moreThanTwoBirds { get; }

        public Cage(string newBiome, bool twoMoreBirds)
        {
            Biome = newBiome;
            moreThanTwoBirds = twoMoreBirds;
        }

    }
}
