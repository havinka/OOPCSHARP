using System;
namespace P12_Animal
{
    public class Dog : Animal
    {
        public Dog(string name, string favFood) : base(name, favFood)
        {
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + " Djaff";
        }
    }
}

