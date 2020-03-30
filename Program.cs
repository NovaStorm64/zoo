using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    static class Program
    {
        static void Main()
        {



            Cage cagney = new Cage("Rainforest", true);







            //int inputAnimal;
            //bool loop = true;

            //while (loop == true)
            //{
            //    Fish AnglerFish = new Fish("Cocaine", "male", false, "none", "cold water", true, true, 3, 2, "5m x 5m x 5m");
            //    Fish Blobfish = new Fish("Jack", "female", false, "paracetamol", "cold water", true, true, 1, -5, "5m x 5m x 5m");
            //    Fish Pufferfish = new Fish("Lol", "Male", true, "none", "warm water", true, true, 0.05, 25, "5m x 10m x 5m");

            //    Birds Toucan = new Birds("Frog", "male", false, "none", "rainforest", "Black and white", "Large", false, "10ft x 15ft", "squawk");
            //    Birds Cockatoo = new Birds("Kiril", "female", false, "none", "tropical", "Yellow and white", "Snall", false, "5ft x 10ft", "squawk and talk");
            //    Birds Macaw = new Birds("xavier", "female", false, "none", "tropical", "Yellow, Red, Blue, and Green", "Medium", false, "10ft x 15ft", "squawk and talk");

            //    Mammals redPanda = new Mammals("THE WONDERFUL THING ABOUT TIGERS", "Female", false, "None", "cold climates", "FLUFFY", "Squeak", "10pm-5am", 150);
            //    Mammals PolarBear = new Mammals("mog", "Female", false, "None", "Arctic tundra", "Thick fur", "growl", "7pm-8am", 100);
            //    Mammals Tiger = new Mammals("Polly", "Female", false, "None", "Asia", "Thin fur", "growl", "9pm-5am", 300);
            //    Mammals Cheetah = new Mammals("Margaret", "Fe", false, "Pills", "Savannah", "Thin fur", "growl", "9pm-5am", 300);
            //    Mammals Dolphin = new Mammals("Steven", "Female", false, "None", "Tropical Oceans", "Skin", "Whistles and clicks", "-", 400);
            //    Mammals Lemur = new Mammals("Gary", "Male", false, "none", "Treetops", "Slightly Fluffy", "Squeal", "10pm-5am", 150);
            //    Mammals Orca = new Mammals("Dave", "Neuter", true, "nope", "lol", "Skin", "Whale noises", "-", 400);

            //    Animal[] animals = new Animal[] { redPanda, PolarBear, Tiger, Cheetah, Dolphin, Lemur, Orca, Toucan, Cockatoo, Macaw, AnglerFish, Blobfish, Pufferfish };

            //    Console.WriteLine("~~~~~~ENTER AN ANIMAL!~~~~~~");
            //    Console.WriteLine("MAMMALS");
            //    Console.WriteLine("1 - Red Panda");
            //    Console.WriteLine("2 - Polar Bear");
            //    Console.WriteLine("3 - Tiger");
            //    Console.WriteLine("4 - Cheetah");
            //    Console.WriteLine("5 - Dolphin");
            //    Console.WriteLine("6 - Lemur");
            //    Console.WriteLine("7 - Orca");
            //    Console.WriteLine("BIRDS");
            //    Console.WriteLine("8 - Toucan");
            //    Console.WriteLine("9 - Cockatoo");
            //    Console.WriteLine("10 - Macaw");
            //    Console.WriteLine("FISH");
            //    Console.WriteLine("11 - Angler Fish");
            //    Console.WriteLine("12 - Blobfish");
            //    Console.WriteLine("13 - Pufferfish");

            //    //for (int x = 0; x != animals.Length; x++)
            //    //{
            //    //    Console.WriteLine(x + 1 + " - " + animals.Name[x]);
            //    //}

            //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            //    //Console.WriteLine("-1 -  Create an animal");
            //    Console.WriteLine("0 - Exit the Program");
            //    Console.Write(">>> ");
            //    inputAnimal = Int32.Parse(Console.ReadLine());

            //    Console.Clear();


            //    if (inputAnimal == 0)
            //    {
            //        loop = false;
            //    }
            //    //else if (inputAnimal == -1)
            //    //{
            //    //    animalMaker();
            //    //}
            //    else
            //    {
            //        DisplayStuff(animals[inputAnimal - 1]);
            //        Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            //        Console.WriteLine("Press enter to exit");
            //        Console.Write(">>> ");
            //        Console.ReadLine();
            //        Console.Clear();
            //    }

            //}
        }

        public static void DisplayStuff(Animal animal)
        {
            Console.WriteLine("Name: " + animal.Name);
            Console.WriteLine("Age: " + animal.Age);
            Console.WriteLine("Gender: " + animal.Gender);
            Console.WriteLine("Diet: " + animal.Diet);
            Console.WriteLine("Weight: " + animal.Weight);
            Console.WriteLine(animal.GetIll);

            if (animal is Mammals mammal)
            {
                displayMammals(mammal);
            }
            else if (animal is Birds birds)
            {
                displayBirds(birds);
            }
            else if (animal is Fish fish)
            {
                displayFish(fish);
            }
        }
        public static void displayMammals(Mammals animal)
        {
            Console.WriteLine("~~~~~~MAMMAL-SPECIFIC DATA~~~~~~");
            Console.WriteLine("Fur Type: " + animal.FurType);
            Console.WriteLine("Noise: " + animal.Noise);
            Console.WriteLine("Sleep Schedule: " + animal.SleepSchedule);
            Console.WriteLine("Daily Exercise needed: " + animal.ExerciseNeeded + "m");
        }
        public static void displayBirds(Birds animal)
        {
            Console.WriteLine("~~~~~~BIRD-SPECIFIC DATA~~~~~~");
            Console.WriteLine("Beak size: " + animal.BeakSize);
            Console.WriteLine("Colour: " + animal.ColourOfFeathers);
            Console.WriteLine("Is Depressed? " + animal.Depression);
            Console.WriteLine("Optimum Enclosure size: " + animal.Enclosure);
            Console.WriteLine("Beak size: " + animal.BeakSize);
            Console.WriteLine("Noise: " + animal.Noise);
        }

        public static void displayFish(Fish animal)
        {
            Console.WriteLine("~~~~~~FISH-SPECIFIC DATA~~~~~~");
            Console.WriteLine("Has Gills? " + animal.Gills);
            Console.WriteLine("Has Fins? " + animal.Fins);
            Console.WriteLine("Optimum depth: " + animal.Depth);
            Console.WriteLine("Optimum Water temperature: " + animal.WaterTemperature + "°C");
            Console.WriteLine("Best Tank size: " + animal.TankSize);
        }

//        public static void animalMaker()
//        {
//            string tempCatag;
//            string newCatag;
//            string newSpecies;
//            string newName;
//            string newGender;
//            string newHabitat;
//            string tempPoisonous;
//            bool newPoisonous;
//            string newMedication;

//            Console.Clear();

//            Console.WriteLine("Enter the CATAGORY of the animal (1 - Mammal, 2 - Bird or 3 - Fish)");
//            Console.Write(">>> ");
//            tempCatag = Console.ReadLine();
//            if (tempCatag == "1")
//            {
//                newCatag = "Mammal";
//            }
//            else if (tempCatag == "2")
//            {
//                newCatag = "Bird";
//            }
//            else if (tempCatag == "3")
//            {
//                newCatag = "Fish";
//            }
//            Console.WriteLine("What SPECIES of animal is it?");
//            Console.Write(">>> ");
//            newSpecies = Console.ReadLine();
//            Console.WriteLine("Enter the NAME of the animal");
//            Console.Write(">>> ");
//            newName = Console.ReadLine();

//            Console.WriteLine("Enter the GENDER of the animal");
//            Console.Write(">>> ");
//            newGender = Console.ReadLine();
//            Console.WriteLine("Enter the animal's HABITAT");
//            Console.Write(">>> ");
//            newHabitat = Console.ReadLine();
//            Console.WriteLine("Is the animal POISONOUS? y/n");
//            Console.Write(">>> ");
//            tempPoisonous = Console.ReadLine();
//            if (tempPoisonous == "y" | tempPoisonous == "Y")
//            {
//                newPoisonous = true;
//            }
//            else if (tempPoisonous == "n" | tempPoisonous == "N")
//            {
//                newPoisonous = false;
//            }
//            Console.WriteLine("Enter any MEDICATION the animal takes");
//            Console.Write(">>> ");
//            newMedication = Console.ReadLine();

//            if (tempCatag == "1")
//            {
//                MammalMaker(newCatag, newSpecies, newName, newGender, newHabitat, newPoisonous, newMedication);
//            }
//            else if (tempCatag == "2")
//            {
//                BirdMaker(newCatag, newSpecies, newName, newGender, newHabitat, newPoisonous, newMedication);
//            }
//            else if (tempCatag == "3")
//            {
//                FishMaker(newCatag, newSpecies, newName, newGender, newHabitat, newPoisonous, newMedication);
//            }
//        }

//        public static void MammalMaker(string Catagory, string Species, string Name, string Gender, string Habitat, bool Poisonous, string Medication)
//        {
//            string FurType;
//            string Noise;
//            string Sleep;
//            string Exercise;

//            Console.WriteLine("Enter the animal's FUR TYPE");
//            Console.Write(">>> ");
//            FurType = Console.ReadLine();
//            Console.WriteLine("Enter the NOISE the animal makes");
//            Console.Write(">>> ");
//            Noise = Console.ReadLine();
//            Console.WriteLine("Enter the animal's SLEEP SCHEDULE");
//            Console.Write(">>> ");
//            Sleep = Console.ReadLine();
//            Console.WriteLine("Enter how much EXERCISE the animal needs per day (in Metres)");
//            Console.Write(">>> ");
//            Exercise = Console.ReadLine();

//            //Mammals Species = new Mammals(Name, Gender, Poisonous, Medication, Habitat, FurType, Noise, Sleep, Exercise);
//        }

//        public static void BirdMaker(string Catagory, string Species, string Name, string Gender, string Habitat, bool Poisonous, string Medication)
//        {
//            string colourOfFeathers;
//            int beakSize;
//            string tempDepression;
//            bool Depression;
//            int enclosure;
//            string noise;

//            Console.WriteLine("Enter the COLOUR of the Bird's FEATHERS");
//            Console.Write(">>> ");
//            colourOfFeathers = Console.ReadLine();
//            Console.WriteLine("Enter the SIZE of the Bird's BEAK (cm)");
//            Console.Write(">>> ");
//            beakSize = int.Parse(Console.ReadLine());
//            Console.WriteLine("Is the Bird DEPRESSED? (y/n)");
//            Console.Write(">>> ");
//            tempDepression = Console.ReadLine();
//            if (tempDepression == "y" | tempDepression == "Y")
//            {
//                Depression = true;
//            }
//            else if (tempDepression == "n" | tempDepression == "N")
//            {
//                Depression = false;
//            }
//            Console.WriteLine("Enter the size of the Bird's ENCLOSURE (in Metres cubed)");
//            Console.Write(">>> ");
//            enclosure = int.Parse(Console.ReadLine());

//            //Birds Species = new Birds(Name, Gender, Poisonous, Medication, Habitat, FurType, Noise, Sleep, Exercise);
//        }

//        public static void FishMaker(string Catagory, string Species, string Name, string Gender, string Habitat, bool Poisonous, string Medication)
//        {
//            string tempGills;
//            bool gills;
//            string tempFins;
//            bool fins;
//            double waterTemp;
//            int waterDepth;
//            int tankSize;

//            Console.WriteLine("Does the FIsh have GILLS? (y/n)");
//            Console.Write(">>> ");
//            tempGills = Console.ReadLine();
//            if (tempGills == "y" | tempGills == "Y")
//            {
//                gills = true;
//            }
//            else if (tempGills == "n" | tempGills == "N")
//            {
//                gills = false;
//            }
//            Console.WriteLine("Does the Fish have FINS? (y/n)");
//            Console.Write(">>> ");
//            tempFins = Console.ReadLine();
//            if (tempFins == "y" | tempFins == "Y")
//            {
//                fins = true;
//            }
//            else if (tempFins == "n" | tempFins == "N")
//            {
//                fins = false;
//            }
//            Console.WriteLine("What is the optimum DEPTH of water for the Fish? (Metres)");
//            Console.Write(">>> ");
//            waterDepth = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter the size of the Fish's TANK (in Metres cubed)");
//            Console.Write(">>> ");
//            tankSize = int.Parse(Console.ReadLine());

//            //Fish Species = new Fish(Name, Gender, Poisonous, Medication, Habitat, FurType, Noise, Sleep, Exercise);
//        }
    }
}
