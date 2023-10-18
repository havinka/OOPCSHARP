using System;
namespace P12_Animal
{
    public class Cat : Animal
    {
        public Cat(string name, string favFood) : base(name, favFood)
        {
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + " Meow... meowwwww... meooowwwww";
        }
    }
}

