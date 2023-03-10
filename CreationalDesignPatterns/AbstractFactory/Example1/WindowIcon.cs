using System;
namespace CreationalDesignPatterns.AbstractFactory.Example1
{
	public class WindowIcon : IIcon
	{
		public WindowIcon()
		{
		}

        public void ShowIcon()
        {
            Console.WriteLine("Show Window Style Icons...");
        }
    }
}

