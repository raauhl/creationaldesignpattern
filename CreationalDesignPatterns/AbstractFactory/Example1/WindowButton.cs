using System;
namespace CreationalDesignPatterns.AbstractFactory.Example1
{
	public class WindowButton : IButton
	{
		public WindowButton()
		{
		}

        public void ShowButton()
        {
            Console.WriteLine("Show Window Style Button...");
        }
    }
}

