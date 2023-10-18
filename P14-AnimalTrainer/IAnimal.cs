using System;
namespace P14_AnimalTrainer
{
	public interface IAnimal:IMakeNoise, IMakeTrick
	{
		public void Perform();
	}
}

