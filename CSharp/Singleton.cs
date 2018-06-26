using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{  
    public class Singleton
    {
        private static Singleton _instance;

        // Constructor is 'protected'
        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
    

    public class SingletonUsage
    {
        public SingletonUsage()
        {
            // Constructor is protected -- cannot use new
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Singleton: Objects are the same instance");
            }
        }
    }
}
