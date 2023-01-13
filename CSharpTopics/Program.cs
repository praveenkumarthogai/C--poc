using System;

namespace CSharpTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenericCollections.List();
            //GenericCollections.Dictionary();
            //GenericCollections.Stack();
            //GenericCollections.Queue();

            //OutKeyword outKeyword = new OutKeyword();
            //outKeyword.GetEmployeeName(1);



            //GenericMethod<int> genericMethod = new GenericMethod<int>();
            //genericMethod.PrintGivenValue(100);
            //GenericMethod<string> genericMethod1 = new GenericMethod<string>();
            //genericMethod1.PrintGivenValue("hey ");

            //GenericMethodExampleTwo genericMethod = new GenericMethodExampleTwo();
            //genericMethod.PrintGivenValue<string>("Hey");
            //genericMethod.PrintGivenValue<int>(100);

            //DelegateTest delegateTest = new DelegateTest();
            //delegateTest.DelegateEx();
            SingleAndMultiCastDelegate delegateExample = new SingleAndMultiCastDelegate();
            delegateExample.CalculationTwo();

        }

        public class DelegateTest {
            public void DelegateEx()
            {
                WorkPerformedHandler del1 = new WorkPerformedHandler(Worker_WorkPerformed);
                WorkCompletedHandler del2 = new WorkCompletedHandler(Worker_WorkCompleted);
                Worker worker = new Worker();
                worker.DoWork(1, "Generating Report", del1, del2);
                Console.ReadKey();
            }


            //Delegate Signature must match with the method signature
            static void Worker_WorkPerformed(int hours, string workType)
            {
                Console.WriteLine($"{hours} Hours compelted for {workType}");
                Console.ReadKey();
            }
            static void Worker_WorkCompleted(string workType)
            {
                Console.WriteLine($"{workType} work compelted");
                Console.ReadKey();
            }
        }
    }
}
