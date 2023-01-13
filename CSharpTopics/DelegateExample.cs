using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTopics
{
    public class DelegateExample
    {
        //A delegate is a reference type that holds the reference of a class method.
        //Any method which has the same signature as delegate can be assigned to delegate.
        //Delegate accepts method name as paramter in the constructor.
        //In simple it works as callback | function pointer

        //Single cast Delegate

        //A single cast delegate holds the reference of only single method.In previous example, created delegate is a single cast delegate.


        //Multi Cast Delegate

        //A delegate which holds the reference of more than one method is called multi-cast delegate.

        public void Add(int x ,int y)
        {
            Console.WriteLine($"Add Method called Output - {x+y}" );
        } 

        public void Subtract(int x,int y)
        {
            Console.WriteLine($"Subtract Method called Output - {x - y}");
        }

        public void Multiply(int x , int y)
        {
            Console.WriteLine($"Multiply Method called Output - {x * y}");
        }

    }

    public class SingleAndMultiCastDelegate
    {

        public delegate void Action(int x, int y);

        //Single Delegate
        public void CalculationOne()
        {
            DelegateExample delegateExample = new DelegateExample();

            Action action = new Action(delegateExample.Add);

            action(5,5);
            Console.ReadKey();
        }


        //Multi Delegate
        public void CalculationTwo()
        {
            DelegateExample delegateExample = new DelegateExample();

            Action action = new Action(delegateExample.Add);
            action += new Action(delegateExample.Subtract);
            action += new Action(delegateExample.Multiply);
            action(5, 5);
            Console.ReadKey();
        }
    }
}
