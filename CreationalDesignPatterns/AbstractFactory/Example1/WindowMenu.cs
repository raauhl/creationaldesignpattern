using System;
namespace CreationalDesignPatterns.AbstractFactory.Example1
{
	public class WindowMenu : IMenu
	{
		public WindowMenu()
		{
		}

        public void ShowMenu()
        {
            Console.WriteLine("Show Window Style Menu...");
        }
    }
}

