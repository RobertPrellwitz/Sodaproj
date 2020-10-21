using System;
using System.Collections.Generic;
namespace SodaMachine
{
    public class Wallet : Customer
    {
        public double totalWallet;
        public List<Coin> coins;
        public Wallet()
        {
            totalWallet = 0;
            coins = new List<Coin>();

            for (int i = 0; i < 15; i++)
            {
                coins.Add(new Quarter());
                coins.Add(new Dime());
                coins.Add(new Nickel());
            }
            for (int i = 0; i < coins.Count; i++)
            {
               totalWallet = Math.Round(totalWallet + coins[i].Value,2);
            }

        }

        
    }
}
