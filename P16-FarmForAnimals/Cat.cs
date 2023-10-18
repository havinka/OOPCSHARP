using System;
namespace P17_FarmForAnimals
{
	public class Cat:Felime
	{
		public string Breed { get; set; }

        public override string MakeSound()
        {
            return "Meowwww";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{AnimalName}, {Breed}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}

