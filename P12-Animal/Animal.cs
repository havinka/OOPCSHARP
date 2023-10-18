using System;
namespace P12_Animal
{
	public class Animal
	{
        public Animal(string name, string favFood)
        {
            Name = name;
            FavFood = favFood;
        }
        
        public string Name { get; set; }

		public string FavFood { get; set; }

		public virtual string ExplainMyself()
		{
			return $"I am {this.Name} and my fovourite food is {this.FavFood}";

        }
    }
}

