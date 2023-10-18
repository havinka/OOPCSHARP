using System;
namespace P14_AnimalTrainer
{
    public class Rabbit : IAnimal
    {
        public string IMakeNoise()
        {
            return "I don't make noise";
        }

        public string IMakeTrick()
        {
            return "Jumping...";
        }

        public void Perform()
        {
            Console.WriteLine(IMakeNoise());
            Console.WriteLine(IMakeTrick());
        }
    }
}

