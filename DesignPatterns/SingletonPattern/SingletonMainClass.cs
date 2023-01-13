using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class SingletonMainClass
    {
        //Maintainig same or single instance for entire life cycle
        public void MainMethodCall()
        {
            Singleton instanceOne = Singleton.GetInstance;
            Singleton instanceTwo = Singleton.GetInstance;

            int result1 = instanceOne.Increment();
            Console.WriteLine(result1);
            int result2 = instanceTwo.Increment();
            Console.WriteLine(result2);
        }
    }
}
