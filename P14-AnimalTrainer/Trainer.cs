using System;
namespace P14_AnimalTrainer
{
	public class Trainer
	{
		public Trainer(IAnimal animal)
		{
			Animal = animal;
		}

		public IAnimal Animal { get; set; }

		public void Make()
		{
			Animal.Perform();
		}
	}
}

