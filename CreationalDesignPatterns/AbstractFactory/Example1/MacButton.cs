using System;
namespace CreationalDesignPatterns.AbstractFactory.Example1
{
	public class MacButton : IButton
	{
		public MacButton()
		{
		}

		public void ShowButton()
		{
			Console.WriteLine("Show Mac Style Button...");
		}
	}
}

