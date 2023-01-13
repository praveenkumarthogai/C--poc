using System;

namespace CSharpTopics
{
    //T can be any type , type of T defined at runtime
    //Benefit is code resue and typesafty
    public class GenericMethod<T>
    {
        public void PrintGivenValue (T input)
        {
            Console.WriteLine($"{input} - {input.GetType()}" );
            Console.ReadKey();
        }

        public void Test(string param)
        {

        }
    }


    public class GenericMethodExampleTwo
    {
        public void PrintGivenValue<T>(T input)
        {
            Console.WriteLine($"{input} - {input.GetType()}");
            
        }
    }
}
