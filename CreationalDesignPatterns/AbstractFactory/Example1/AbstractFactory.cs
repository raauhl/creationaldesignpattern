using System;
namespace CreationalDesignPatterns.AbstractFactory.Example1
{
	public abstract class AbstractFactory
	{
		public AbstractFactory()
		{
		}

		public abstract IButton CreateButton();

        public abstract IMenu CreateMenu();

        public abstract IIcon CreateIcon();
    }
}

