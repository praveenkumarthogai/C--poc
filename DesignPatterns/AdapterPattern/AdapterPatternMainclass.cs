using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class AdapterPatternMainclass
    {
        //David -- French guy
        //John -- English guy
        public void MainMethod()
        {
            string replyFromDavid = new AmericanPerson().AskQuestion("how are you?");
            Console.WriteLine("Reply From David [French Speaker can Speak and Understand only French] :  " + replyFromDavid);
            Console.WriteLine();
            string replyFromJohn = new FrenchPerson().AskQuestion("où êtes-vous?");
            Console.WriteLine("Reply From John [English Speaker can Speak and Understand only English] :  " + replyFromJohn);

            Console.Read();
        }

    }
}
