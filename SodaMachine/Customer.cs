using System;
using System.Collections.Generic;
namespace SodaMachine
{
    public class Customer
    {
        public Can selection;
        public BackPack pack;
        public Wallet walletobj;
        public List<Coin> payment;
        public Quarter quarter;
        public Dime dime;
        public Nickel nickel;
        public Penny penny;
        public Cola cola;
        public Orange orange;
        public RootBeer rootBeer;
        //public Coin coin;

        public Customer()
        {

            cola = new Cola();
            rootBeer = new RootBeer();
            orange = new Orange();
            pack = new BackPack();
            walletobj = new Wallet();

        }


        public void ChooseSoda(List<Can>cans,int choice)
        {
            
                if (choice == 1)
                {
                
                    Console.WriteLine($"Please put in ${Cola.price}");
                    foreach (var can in cans)
                    {
                        if (can.name == "Cola")
                        {
                            selection = can;
                            break;
                        }
                    }
                    
                }
                else if (choice == 2)
                {
                    Console.WriteLine($"Please put in ${RootBeer.price}");
                    foreach (var can in cans)
                    {
                        if (can.name == "Root Beer")
                        {
                            selection = can;
                            break;
                        }
                    }
                }

                else if (choice == 3)
                {
                    Console.WriteLine($"Please put in ${Orange.price}");
                    foreach (var can in cans)
                    {
                        if (can.name == "Orange")
                        {
                            selection = can;
                            break;
                        }
                    }
                }
        }

        
        public void MakePayment(List<Coin> coins)
        {
            payment = new List<Coin>();
            double hand = 0;
            int temp=1;
            int choice;
            do
            {
                choice = UserInterface.CoinCheck();
                
                    if (choice == 1)
                    {
                        foreach (var item in coins)
                        {
                            if (item.name == "penny")
                            {
                                walletobj.coins.Remove(item);
                                payment.Add(item);
                                hand = hand + item.Value;
                                break;
                            }
                        }
                    }
                    if (choice == 2)
                    {
                        foreach (var item in coins)
                        {
                            if (item.name == "nickel")
                            {
                                walletobj.coins.Remove(item);
                                payment.Add(item);
                                hand = hand + item.Value;
                                break;
                            }
                        }
                    }
                    if (choice == 3)
                    {
                        foreach (var item in coins)
                        {
                            if (item.name == "dime")
                            {
                                walletobj.coins.Remove(item);
                                payment.Add(item);
                                hand = hand + item.Value;
                                break;
                            }
                        }
                    }
                    if (choice == 4)
                    {
                        foreach (var item in coins)
                        {
                            if (item.name == "quarter")
                            {
                                walletobj.coins.Remove(item);
                                payment.Add(item);
                                hand = hand + item.Value;
                                break;
                            }
                        }
                    }
                    Console.WriteLine($"You have selected coins that total {Math.Round(hand,2)}\n" );
                    
                    temp = UserInterface.inputCheck();
                    
                   
            }

            while (temp == 1);     
        }

        public void AddToBackPack()
        {
            pack.sodas.Add(selection);
        }
        public void AddToWallet(List<Coin> coins)
        {
            for (int i = 0; i < coins.Count; i++)
            {
                walletobj.coins.Add(coins[i]);
            }
        }

       
       
    }

}

