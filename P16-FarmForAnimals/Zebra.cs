using System;
namespace P17_FarmForAnimals
{
	public class Zebra:Mammal
	{
        public override string MakeSound()
        {
            return "Zs";
        }

        public override string Eat(Food food)
        {
            if (food.GetType().Name == nameof(Meat))
            {
                return $"{GetType().Name} are not eating that type of food!";
            }
            return base.Eat(food);
        }
    }
}

