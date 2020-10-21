using System;
using System.Collections.Generic;
namespace SodaMachine
{
    public class SodaMachine

    {
        public Customer customer;
        public int colaCount;
        public int rootBeerCount;
        public int orangeCount;
        public double pmt;

        public List<Coin> coins;
        public List<Coin> register;
        public List<Can> inventory;
        public SodaMachine()
        {
            register = new List<Coin>();
            for (int i = 0; i < 20; i++)
            {
                register.Add(new Quarter());
                register.Add(new Nickel());

            }
            for (int i = 0; i < 50; i++)
            {
                register.Add(new Penny());

            }
            for (int i = 0; i < 10; i++)
            {
                register.Add(new Dime());
            }
            inventory = new List<Can>();

            for (int i = 0; i < 15; i++)
            {
                inventory.Add(new Cola());
                inventory.Add(new RootBeer());
                inventory.Add(new Orange());

            }
        }

        
        public void CurrentInventory()
        {
            colaCount = 0; rootBeerCount = 0; orangeCount = 0;
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].name == "Cola")
                {
                    colaCount = ++colaCount;
                }
                else if (inventory[i].name == "Root Beer")
                {
                    rootBeerCount = ++rootBeerCount;
                }
                else if (inventory[i].name == "Orange")
                {
                    orangeCount = ++orangeCount;
                }

            }
            Console.WriteLine($"The machine currently holds the following:\n" +
                 $"{colaCount} colas \n{rootBeerCount} Root Beer" +
                 $"\n{orangeCount} orange sodas");

        }
        public void ProcessPayment()
        {
             pmt=0;
            for (int i = 0; i < customer.payment.Count; i++)
            {
                pmt = pmt + customer.payment[i].Value;
            }
            if (pmt < customer.selection.Cost)
            {
                // return money
            }
            else if (pmt == customer.selection.Cost)
            {
                DepositPayment();
                DispenseProduct();
            }
            else if (pmt > customer.selection.Cost)
            {
                DepositPayment();
                DispenseProduct();
                MakeChange();
            }


        }
        public void DepositPayment()
        {
            for (int i = 0; i < customer.payment.Count; i++)
            {
                register.Add(customer.payment[i]);
            }
       
        }

        public void MakeChange()//Quarter quarter, Dime dime, Nickel nickel, Penny penny)
        {
            double change = pmt - customer.selection.Cost;
            coins = new List<Coin>();
            while (change > register.)
            {
                coins.Add(quarter);
                change = change - quarter.Value;
            }
            while (change > dime.Value)
            {
                coins.Add(dime);
                change = change - dime.Value;
            }
            while (change > nickel.Value)
            {
                coins.Add(nickel);
                change = change - nickel.Value;
            }
            while (change > penny.Value)
            {
                coins.Add(penny);
                change = change - penny.Value;
            }


        }
        public void DispenseProduct()
        {
            inventory.Remove(customer.selection);
        }

    }
}
