using System;
namespace P14_AnimalTrainer
{
    public class Bear : IAnimal
    {
        public string IMakeNoise()
        {
            return "I growl";
        }

        public string IMakeTrick()
        {
            return "I am wayyy too fat to do any tricks, I love eating tho.";
        }

        public void Perform()
        {
            Console.WriteLine(IMakeNoise());
            Console.WriteLine(IMakeTrick());
        }
    }
}

