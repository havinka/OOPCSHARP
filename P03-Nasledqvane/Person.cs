using System;

public class Person
{
    public Person()
    {
       
    }

    public string Name { get; set; }

	public string Address { get; set; }

    public string GetNameAndAddress()
    {
        return $"Name: {Name}, from {Address}. ";
    }
}

