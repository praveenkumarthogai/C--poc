using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{

    //Abstracting the instance creation | hiding the instance creations
    //Instance creation will be handled in factory class
    public class MainMethod
    {
        public void GetCreditCardDetails(string cardType)
        {

            ICreditCard cardDetails = CreditCardFactory.GetCreditCard(cardType);

            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
