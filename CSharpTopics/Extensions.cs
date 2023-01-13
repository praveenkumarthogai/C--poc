using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTopics
{
    public class Extensions
    {
        public void Print01()
        {
            Console.WriteLine("Print01 Method Triggered");
        }

        public void Print02()
        {
            Console.WriteLine("Print02 Method Triggered");
        }

    }

    //without modifying the existing class new functionality can be added
    //Extension methods should be in Static class
    public static class Extra
    {
        public static void Print03(this Extensions extensions)
        {
            Console.WriteLine("Print03 Method is triggered");
        }
    }

    //Points to be remember

    //Extension method can add methods to classes in other library as well
    //extension method should be static

    //for Partial class above points won't be applied

}
