using System;
namespace CreationalDesignPatterns.AbstractFactory.Example1
{
	public class MacAbstractFactory : AbstractFactory
	{
		public MacAbstractFactory()
		{
		}

        public override IButton CreateButton()
        {
            return new MacButton();
        }

        public override IMenu CreateMenu()
        {
            return new MacMenu();
        }

        public override IIcon CreateIcon()
        {
            return new MacIcon();
        }
    }
}

