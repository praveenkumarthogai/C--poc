using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{

    //Sealed class cannot be inherited
    //instance can be created
    //Since it has private constructor instance cannot be created
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        private Singleton()
        {
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        public int Increment()
        {
            counter++;
            return counter;
        }

    }
}
