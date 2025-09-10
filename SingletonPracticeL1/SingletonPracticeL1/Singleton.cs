using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPracticeL1
{
    public class Singleton
    {
        private Singleton() // Private constructor to prevent instantiation
        {
        }
        private static object _lock = new object();// Lock object for thread safety
        private static Singleton _instance; // Singleton instance

        public static Singleton GetSingleton()// Public method to get the singleton instance
        {
            if (_instance == null) // First check (no locking)
            {
                lock (_lock) // Double-checked locking
                {
                    if (_instance == null) // Second check (with locking)
                    {
                        //lazy initialization
                        _instance = new Singleton();// Create the singleton instance
                    }
                }
            }
            return _instance;// Return the singleton instance
        }
    }
}
