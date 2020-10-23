using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Serialization;

namespace SodaMachine
{
    public class SodaMachine

    {
        public Customer customer;
        public Quarter quarter;
        public Dime dime;
        public Nickel nickel;
        public Penny penny;

        public int colaCount; 
        public int rootBeerCount;
        public int orangeCount;
        public double pmt;
        public double totalChange;
        public double registerTotal;
        

        public List<Coin> changeCoins;
        public List<Coin> register;
        public List<Can> inventory;
        public SodaMachine()
        {
           // machine initiation 

            register = new List<Coin>();
            for (int i = 0; i < 020; i++)
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

            for (int i = 0; i < 5; i++)
            {
                inventory.Add(new Cola());
                inventory.Add(new RootBeer());
                inventory.Add(new Orange());

            }
        }

        public void RegisterTotal()
        {
            for (int i = 0; i < register.Count; i++)
            {
                registerTotal = registerTotal + register[i].Value;
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
            Console.WriteLine($"\nThe machine currently holds the following:\n" +
                 $"{colaCount} cola -      price {Cola.price} \n{rootBeerCount} Root Beer -   cost  {RootBeer.price}" +
                 $"\n{orangeCount} orange sodas - cost {Orange.price}\n\n");

        }
        // inventory check vs customer selection
        public bool SelectionCheck(int choice)
        {
            CurrentInventory();
            if (choice == 1)
            {
                if (colaCount > 0)
                {
                    Console.WriteLine("Nice Choice!");
                    return true;
                }
                else 
                {
                    Console.WriteLine("Cola inventory has been depleted. Perhaps another choice will suit you!");
                    return false;
                }
            }
            if (choice == 2)
            {
                if (rootBeerCount > 0)
                {
                    Console.WriteLine("My Favorite! Excellent Choice");
                    return true;
                }
                else
                {
                    Console.WriteLine("Root Beer inventory has been depleted. Perhaps another choice will suit you!");
                    return false;
                }
            }
            if (choice == 3)
            {
                if (orangeCount > 0)
                {
                    Console.WriteLine("Only good when mixed with sprite....");
                    return true;
                }
                else
                {
                    Console.WriteLine("Orange soda inventory has been depleted. Perhaps another choice will suit you!");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void ProcessTransaction(Customer customer)
        {
            RegisterTotal();
             pmt=0;
            for (int i = 0; i < customer.payment.Count; i++)
            {
                pmt = pmt + customer.payment[i].Value;
            }
            
            if (pmt < customer.selection.Cost)
            {
                
                Console.WriteLine("You did not put in enough money for this item");
                customer.AddToWallet(customer.payment);
            }
            else if (pmt == customer.selection.Cost)
            {
                DepositPayment(customer);
                DispenseProduct(customer);
            }
            else if (pmt > customer.selection.Cost)

            {
                if ((pmt - customer.selection.Cost) > registerTotal)
                {
                    Console.WriteLine("Please use exact change");
                    customer.AddToWallet(customer.payment);
                }
                else
                {
                    double change = (pmt - customer.selection.Cost);
                    DepositPayment(customer);
                    DispenseProduct(customer);
                    MakeChange(customer, register, change);
                    TotalChange();
                    Console.WriteLine($"Your Change is {totalChange}");
                    customer.AddToWallet(changeCoins);
                }
            }


        }
        public void DepositPayment(Customer customer)
        {
            for (int i = 0; i < customer.payment.Count; i++)
            {
                register.Add(customer.payment[i]);
            }
       
        }

        public void MakeChange(Customer customer, List<Coin> coins, double change)
        {
            //Math.Round()
            changeCoins = new List<Coin>();
            while (change > 0.25)
            {
                foreach (var item in coins)
                {
                    if (item.Value == 0.25)
                    {
                        register.Remove(item);
                        changeCoins.Add(item);
                        change = change - item.Value;
                        break;
                    }
                }

            }
            while (change > 0.10)
            {
                foreach (var item in coins)
                {
                    if (item.Value == 0.10)
                    {
                        register.Remove(item);
                        changeCoins.Add(item);
                        change = change - item.Value;
                        break;
                    }
                }

            }
            while (change > 0.05)
            {
                foreach (var item in coins)
                {
                    if (item.Value == 0.05)
                    {
                        register.Remove(item);
                        changeCoins.Add(item);
                        change = change - item.Value;
                        break;
                    }
                }
            }
            while (change > 0.01)
            {
                foreach (var item in coins)
                {
                    if (item.Value == 0.01)
                    {
                        register.Remove(item);
                        changeCoins.Add(item);
                        change = change - item.Value;
                        break;
                    }
                }
            }


        }
        public void TotalChange()
        {
            totalChange =0;
            for (int i = 0; i < changeCoins.Count; i++)
            {
                totalChange = totalChange + changeCoins[i].Value;

            }
        }

        public void DispenseProduct(Customer customer)
        {
            Can can = customer.selection;
            inventory.Remove(can);
        }
    }
}
