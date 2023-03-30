using System;
namespace CreationalDesignPatterns.SingletonPattern.Example1
{
    public class SingletonExample1
    {
        public SingletonExample1()
        {
        }

        public static void Demo()
        {
            DatabaseReader databaseReader = DatabaseReader.GetInstance();
            databaseReader.ShowInfo();
        }
    }
}

