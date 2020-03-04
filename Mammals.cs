using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Mammals : Animal 
    {
        public string FurType { get; }
        public string Noise { get; }
        public string SleepSchedule { get; }
        public double ExerciseNeeded { get; set; }

        public Mammals(string newName, string newGender, bool newPoisonous, string newMedication, string newHaitat, string newFurType, string newNoise, string newSleepSchedule, int newExercise) : base(newName, newGender, newPoisonous, newMedication, newHaitat)
        {
            FurType = newFurType;
            Noise = newNoise;
            SleepSchedule = newSleepSchedule;
            ExerciseNeeded = newExercise;
        }
    }
}
