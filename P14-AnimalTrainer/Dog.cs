using System;
namespace P14_AnimalTrainer
{
    public class Dog : IAnimal
    {
        public string IMakeNoise()
        {
            return "Wooof";
        }

        public string IMakeTrick()
        {
            return "Hold my paw, human!";
        }

        public void Perform()
        {
            Console.WriteLine(IMakeNoise());
            Console.WriteLine(IMakeTrick());
        }
    }
}

