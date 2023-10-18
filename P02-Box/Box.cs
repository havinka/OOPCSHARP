using System;

public class Box<T>
{
	private List<T> items;

    public Box()
    {
        items = new List<T>();
        Count++;
    }

    public string Color { get; set; }

    public int Count { get; private set; }

    public void Add(T item)
    {
        this.items.Add(item);
    }

    public T Remove()
    {
        if (items.Count < 0)
        {
            return default;
        }

        T item = items[0];
        items.RemoveAt(0);
        return item;
    }

    public override string ToString()
    {
        return $"{items.FirstOrDefault().GetType().FullName}: {string.Join(", ", items)} ";
    }
}



