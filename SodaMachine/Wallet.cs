using System;
using System.Collections.Generic;
namespace SodaMachine
{
    public class Wallet : Customer
    {
        public double totalWallet;
        public List<Coin> coins;
        public int quarterCount;
        public int dimeCount;
        public int nickelCount;
        public int pennyCount;
        public SodaMachine sodaMachine;

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
                totalWallet = Math.Round(totalWallet + coins[i].Value, 2);
            }

        }
        public void CurrentChange()
        {
            quarterCount = 0; dimeCount = 0; nickelCount = 0; pennyCount = 0;
            for (int i = 0; i < coins.Count; i++)
            {
                if (coins[i].name == "penny")
                {
                    pennyCount = ++pennyCount;
                }
                else if (coins[i].name == "nickel")
                {
                    nickelCount = ++nickelCount;
                }
                else if (coins[i].name == "dime")
                {
                    dimeCount = ++dimeCount;
                }
                else if (coins[i].name == "quarter")
                {
                    quarterCount = ++quarterCount;
                }

            }
            Console.WriteLine($"Your wallet currently holds\n{pennyCount} pennies" +
                $"\n{nickelCount} nickels\n{dimeCount} dimes\n{quarterCount} quarters");


        }

        public void removeCoins()
        {
            for (int i = 0; i < payment.Count; i++)
            {
                if (payment[i] == quarter)
                {
                    coins.Remove(quarter);
                }
                if (payment[i] == dime)
                {
                    coins.Remove(dime);
                }
                if (payment[i] == nickel)
                {
                    coins.Remove(nickel);
                }
                if (payment[i] == penny)
                {
                    coins.Remove(penny);
                }
            }
        }
        public void addCoins()
        {
            for (int i = 0; i < sodaMachine.changeCoins.Count; i++)
            {
                if (sodaMachine.changeCoins[i] == quarter)
                {
                    coins.Add(quarter);
                }
                if (sodaMachine.changeCoins[i] == dime)
                {
                    coins.Add(dime);
                }
                if (sodaMachine.changeCoins[i] == nickel)
                {
                    coins.Add(nickel);
                }
                if (sodaMachine.changeCoins[i] == penny)
                {
                    coins.Add(penny);
                }
            }
        }
    }
}