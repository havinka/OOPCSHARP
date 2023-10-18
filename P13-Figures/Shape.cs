using System;
namespace P13_Figures
{
	public abstract class Shape
	{
		public abstract double CalculatePerimeter();

		public abstract double CalculateArea();

		public virtual string Draw()
		{
			return "I am something and you are nothing!!!!!!!";
		}

    }
}

