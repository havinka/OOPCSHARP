using System;
namespace P17_FarmForAnimals
{
	public abstract class Mammal:Animal
	{
		public string LivingRegion { get; set; }

        public override string Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
            return $"{this.GetType().Name} eating {food.GetType().Name}";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }

    }
}

