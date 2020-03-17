namespace Zoo
{
    internal class Fish : Animal
    {
        public bool Gills { get; }
        public bool Fins { get; }
        public double Depth { get; }
        public double WaterTemperature { get; }
        public string TankSize { get; }

        public Fish(string newName, string newGender, bool newPoisonous, string newMedication, string newHaitat, bool newGills, bool newFins, double newDepth, double newWaterTemperature, string newTankSize) : base(newName, newGender, newPoisonous, newMedication, newHaitat)
        {
            Gills = newGills;
            Fins = newFins;
            Depth = newDepth;
            WaterTemperature = newWaterTemperature;
            TankSize = newTankSize;
        }
    }
}