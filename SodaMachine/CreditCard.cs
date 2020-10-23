using System;
namespace SodaMachine
{
    public class CreditCard
    {
        public string name;
        double creditLimit;
        public double availableFunds;

        public CreditCard()
        {
            name = "Apple Card";
            creditLimit = 3500;
            availableFunds = 2750;
        }

        public void CreditPmt (Double price)
        {
            availableFunds = availableFunds - price;
        }
    }

}
