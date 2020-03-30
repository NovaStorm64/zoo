using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Environment
    {
        
        List<Animal> animals = new List<Animal>();

        public int temperature { get; }
        public int size { get; }
        public int visitorNumber { get; set; }
        public int noOfAnimals { get; set; }


        private Animal anim;
        public Environment(Animal anim)
        {
            this.anim = anim;
        }
    }
}
