using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Birds : Animal
    {
        public string ColourOfFeathers { get; }
        public string BeakSize { get; }
        public bool Depression { get; }
        public string Enclosure { get; }
        public string Noise { get; set; }

        public Birds(string newName, string newGender, bool newPoisonous, string newMedication, string newHaitat, string newColourOfFeathers, string newBeakSize, bool newDepression, string newEnclosure, string newNoise) : base( newName,  newGender,  newPoisonous,  newMedication,  newHaitat)
        {
            ColourOfFeathers = newColourOfFeathers;
            BeakSize = newBeakSize;
            Depression = newDepression;
            Enclosure = newEnclosure;
            Noise = newNoise;
        }
    }
}
