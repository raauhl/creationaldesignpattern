using System;
namespace CreationalDesignPatterns.AbstractFactory.Example1
{
	public class WindowAbstractFactory : AbstractFactory
	{
		public WindowAbstractFactory()
		{
		}

        public override IButton CreateButton()
        {
            return new WindowButton();
        }

        public override IIcon CreateIcon()
        {
            return new WindowIcon();
        }

        public override IMenu CreateMenu()
        {
            return new WindowMenu();
        }
    }
}

