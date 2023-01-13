using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{

    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            switch (cardType)
            {
                case "Visa":
                    {
                        return new Visa();
                    }

                case "Titanium":
                    {
                        return new Titanium();
                    }

                case "Platinum":
                    {
                        return new Platinum();
                    }

                default:
                    {
                        break;
                    }
            }

            return null;
        }
    }
}
