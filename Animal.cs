using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Zoo
{
    class Animal
    {
        public string Name { get; private set; }
        public string Diet { get; set; }
        public string Gender { get; set; }
        public int Age { get; }
        public double Weight { get; set; }
        public bool Poisonous { get; set; }
        public int Temperature { get; set; }
        public string NaturalHabitat { get; set; }
        public string Medication { get; set; }
        public string GetIll
        {
            get {
                int tempNumber;

                tempNumber = RandomNumber(0, 10);
                if (tempNumber < 2)
                {
                    return "Got ill";
                }
                else
                {
                    return "Healthy";
                }
            }
        }

        public Animal(string newName, string newGender, bool newPoisonous, string newMedication, string newHaitat)
        {   
            Name = newName;
            Diet = "";
            Gender = newGender;
            Age = 0;
            Weight = 0.50;
            Poisonous = newPoisonous;
            Temperature = 25;
            NaturalHabitat = newHaitat;
            Medication = newMedication;
        }       
        public void Breathe()
        {
            Console.WriteLine("Successfully breathed");
        }
        public void Eat()
        {
            Console.WriteLine("Successfully eaten omnomnomnomomnomnomnomomnomnomnomomnomnomnomomnomnomnomomnomnomnomomnomnomnomomnomnomnom");
        }
        public void Excrete()
        {
            Console.WriteLine("Successfully pooped");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzZZzzZZZzzZZZZzzzZZzzzzzZzzZZzZzzZZZzZZZzzZZzzzZZZzzZZzzZzzZZZzzzZZZzzzZZ");
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }    
}
