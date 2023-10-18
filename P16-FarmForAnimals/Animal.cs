using System;
namespace P17_FarmForAnimals
{

	public abstract class Animal

	{
		public string AnimalName { get; set; }

		public double AnimalWeight { get; set; }

		public int FoodEaten { get; set; }


		public abstract string MakeSound();

		public abstract string Eat(Food food);

	}
}
