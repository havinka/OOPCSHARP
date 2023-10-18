using System;
namespace P06_ReusingClasses
{
	public class StackOfStrings
	{
		private List<string> data;

		public void PushData(string item)
		{
			this.data.Add(item);
		}

		public string Pop()
		{
			string element = this.data.Last();
			this.data.Remove(element);
			return element;
		}

		public string Peek()
		{
			string element = this.data.Last();
			return element;
		}

		public bool IsEmpty()
		{
			if (data.Count == 0)
			{
				return true;
			}
			else
			{
                return false;
            }
		}
	}
}

