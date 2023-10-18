using System;

public class Animal
{
    public string Eat()
    {
        return $"eating...";
    }
    private string GetDebuggerDisplay()
    {
        return "THE DOG IS EATING";
    }
}

