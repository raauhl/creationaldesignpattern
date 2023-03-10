using System;
namespace CreationalDesignPatterns.AbstractFactory.Example1
{
	public class MacMenu : IMenu
	{
		public MacMenu()
		{
		}

        public void ShowMenu()
        {
            Console.WriteLine("Show Mac Style Menu...");
        }
    }
}

