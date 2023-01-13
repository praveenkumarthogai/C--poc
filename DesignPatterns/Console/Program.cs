using AdapterPattern;
using FactoryPattern;
using SingletonPattern;
using System;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Singleton Pattern
            //SingletonMainClass singletonMainClass = new SingletonMainClass();
            //singletonMainClass.MainMethodCall();

            ////factory pattern
            //MainMethod mainMethod = new MainMethod();
            //mainMethod.GetCreditCardDetails("Visa");

            //Adapter Pattern
            AdapterPatternMainclass adapterPatternMainclass = new AdapterPatternMainclass();
            adapterPatternMainclass.MainMethod();
        }
    }
}
