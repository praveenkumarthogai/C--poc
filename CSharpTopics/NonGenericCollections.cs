using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpTopics
{
    public class NonGenericCollections
    {
        //Due to boxing and unboxing performance will be slow then generic collections
        //It accepts multiple data type so validation and error handling will be hard
        public void ArrayList()
        {
            ArrayList al = new ArrayList();
            al.Add("Praveen"); //boxing
            al.Add(99999999999999);
            al.Add(true);
            //data stored as object
            //Boxing and unboxing is neccessary

            string value = (string)al[1]; //unboxing
            string value2 = (string)al[0]; ///unboxing

        }

        //Both key and value will be stored as object type
        public void HashTable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "praveen");
            hashtable.Add("2", 99999999999999);


            string value = (string)hashtable[1];
        }


        //----------Difference between Dictionary | hashtable -----------------------

        //    dictionary is Type safe | hash table accepts any data data
        //    dictionary doesn't needs boxing and unboxing | hash table required boxing and unboxing
        //    dictionary throws exception if you try to access non existing key | but hashtable will return null
        //    dictionary won't accept null value | hash table accepts null value

    }
}
