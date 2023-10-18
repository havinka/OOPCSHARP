using System;

public class MyList<T>: List<T>
{
	public string GetReverseElements()
	{
		MyList<string> list = new MyList<string>();
		list.Reverse();
		return string.Join(", ", list);
	}
}

