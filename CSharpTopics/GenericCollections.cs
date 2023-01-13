using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpTopics
{
    //Generic is a concept that allows us to define classes and methods with placeholder.
    //C# compiler replaces these placeholders with specified type at compile time | resolved at compile time
    public class GenericCollections
    {
        //Generic Collection will have single data type so boxing and unboxing is not neccessary 
        //faster performance then non generic collections

        public static void List()
        {
            //List (Index Based Generic Collection)
            //Index Starts from Zero
            List<string> mobilePhones = new List<string>();
            //Adding Item to List
            mobilePhones.Add("Xioami"); //Index 0
            mobilePhones.Add("MicroMax"); //Index 1
            mobilePhones.Add("Nokia"); //Index 2
            mobilePhones.Add("REdmi"); //Index 3

            //Another way of adding items in List
            //List<string> mobilePhones1 = new List<string>() { "Xioami", "MicroMax", "Nokia", "REdmi" };

            //Remove Item from List
            mobilePhones.Remove("Xioami");

            //GetValue by Index
            string mobileName = mobilePhones[2];
            //print the value in console
            Console.WriteLine(mobileName);
            Console.ReadKey();
        }

        public static void Dictionary()
        {
            //Key Value Based Generic Collection
            Dictionary<int, string> studentDetails = new Dictionary<int, string>();
            studentDetails.Add(1, "Michael");
            studentDetails.Add(2, "John");
            studentDetails.Add(3, "Victor");
            studentDetails.Add(4, "James");

            //Another way of adding key value pair items in dictionary
            //Dictionary<int, string> studentDetails1 = new Dictionary<int, string>()
            //{
            //    {1,"Micheal" },
            //    {2,"John" },
            //    {3,"Victor" },
            //    {4,"James" }
            //};

            studentDetails.TryGetValue(2, out string value); // Pass Key to Get Value

            Console.WriteLine(value);
            Console.ReadKey();

            studentDetails.Remove(3); //Remove item by passing Key

        }


        public static void Stack()
        {
            //Priority Based Generic Collection
            //Last In First Out
            //Real Time Example Browser Back Button // Browser Back Buttopn
            Stack<string> browserBacKbutton = new Stack<string>();

            browserBacKbutton.Push("Page1");
            browserBacKbutton.Push("Page2");
            browserBacKbutton.Push("Page3");
            browserBacKbutton.Push("Page4");

            string output = browserBacKbutton.Pop(); // remove the last item
            Console.WriteLine(output);
            Console.ReadKey();

            string output1 = browserBacKbutton.Pop(); // remove the last item
            Console.WriteLine(output1);
            Console.ReadKey();
        }


        public static void Queue()
        {
            //Priority Based Generic Collection
            //First In First Out
            Queue<string> ticketWaitingList = new Queue<string>();

            ticketWaitingList.Enqueue("Ticker reserved by Victor");
            ticketWaitingList.Enqueue("Ticker reserved by James");
            ticketWaitingList.Enqueue("Ticker reserved by Micheal");

            string output = ticketWaitingList.Dequeue();
            Console.WriteLine(output);
            Console.ReadKey();
        }

    }
}
