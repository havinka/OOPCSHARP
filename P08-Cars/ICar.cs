using System;

public interface ICar
{
    public string Model { get; }

    public string Color { get; set; }

    public string Start();

    public string Stop();
}


