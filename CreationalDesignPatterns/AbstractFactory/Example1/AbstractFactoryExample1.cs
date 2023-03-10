using System;
namespace CreationalDesignPatterns.AbstractFactory.Example1
{
	public class AbstractFactoryExample1
    {
        AbstractFactory? abstractFactory;


		public void SetFactory(string environment)
		{
            switch(environment)
            {
                case "window":
                    this.abstractFactory = new WindowAbstractFactory();
                    break;
                case "mac": 
                    this.abstractFactory = new MacAbstractFactory();
                    break;
            }
        }

		public void Demo()
		{
            if (abstractFactory == null)
            {
                return;
            }

			abstractFactory.CreateButton().ShowButton();
			abstractFactory.CreateMenu().ShowMenu();
			abstractFactory.CreateIcon().ShowIcon();
        }
	}
}

