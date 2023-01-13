using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Visa : ICreditCard
    {

        public string GetCardType()
        {
            return "Visa";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }

        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
