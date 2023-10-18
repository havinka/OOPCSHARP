using System;
namespace P14_AnimalTrainer
{
    public class Cat : IAnimal
    {
        public string IMakeNoise()
        {
            return "Meowwww";
        }

        public string IMakeTrick()
        {
            return "No trick for you! I'm too lazy!";
        }

        public void Perform()
        {
            Console.WriteLine(IMakeNoise());
            Console.WriteLine(IMakeTrick());
        }
    }
}

