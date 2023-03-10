using System;
namespace CreationalDesignPatterns.AbstractFactory.Example1
{
	public class MacIcon : IIcon
	{
		public MacIcon()
		{
		}

        public void ShowIcon()
        {
            Console.WriteLine("Show Mac Style Icons...");
        }
    }
}

