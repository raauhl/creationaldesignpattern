using System;
namespace CreationalDesignPatterns.SingletonPattern.Example1
{
    public class DatabaseReader
    {
        private static DatabaseReader databaseReader;

        private static readonly object lockObject = new Object();

        private DatabaseReader()
        {
        }

        public static DatabaseReader GetInstance()
        {
            if (databaseReader == null)
            {
                lock(lockObject)
                {
                    if (databaseReader == null)
                    {
                        databaseReader = new DatabaseReader();
                    }
                }
            }

            return databaseReader;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Database reading singleton object.");
        }
    }
}

