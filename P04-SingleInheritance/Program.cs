using System;
namespace P04_SingleInheritence;

class Program
{
    static void Main()
    {
        
        Dog dog = new Dog();
        Console.WriteLine(dog.Eat());
        Console.WriteLine(dog.Bark());

        Cat cat = new Cat();
        Console.WriteLine(cat.Meow());
        Console.ReadLine();

    }


}

