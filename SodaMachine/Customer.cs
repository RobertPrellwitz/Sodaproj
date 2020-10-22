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
        public void ChooseSoda(List<Can>cans)
        {
            Console.WriteLine($"Please select your soda\n\n 1 for Cola" +
                $"\n2 for Root Beer\n3 for Orange Soda ");
            int choice;
            bool check = Int32.TryParse(Console.ReadLine(), out choice);
            if (check)
            {
                if (choice == 1)
                {
                    Console.WriteLine($"Please put in ${cola.Cost}");
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
                    Console.WriteLine($"Please put in ${rootBeer.Cost}");
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
                    Console.WriteLine($"Please put in ${orange.Cost}");
                    foreach (var can in cans)
                    {
                        if (can.name == "Orange")
                        {
                            selection = can;
                            break;
                        }
                    }
                }
            else
            {
               // ChooseSoda();
            }
        }

        }
        public void MakePayment(List<Coin> coins)
        {
            payment = new List<Coin>();
            ///walletobj.CurrentChange();
            int temp=1;
            do
            {
                // console selection options 1 penny 2 nickel 3 dime 4 quarter
                int choice;
                bool check = Int32.TryParse(Console.ReadLine(), out choice);
                if (check)
                {
                    if (choice == 1)
                    {
                        foreach (var item in coins)
                        {
                            if (item.name == "penny")
                            {
                                payment.Add(item);
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
                                payment.Add(item);
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
                                payment.Add(item);
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
                                payment.Add(item);
                                break;
                            }
                            
                        }
                    }
                    else
                    {
                        //MakePayment();
                    }
                    Console.WriteLine("Would you like to add another coin? 1 = yes 2 = no");

                    temp = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine("Enter your next selection");
            }
            while (temp == 1);
           
             
        }
        public void AddToBackPack()
        {
            pack.sodas.Add(selection);
        }
        //public void BackPackContents()
        //{
        //    for (int i = 0; i < pack.sodas.Count; i++)
        //    {
        //        Console.WriteLine($"{pack.sodas[i].name}");

        //    }
        //}
    }

}

//if (choice == 1)
//{
//    Console.WriteLine($"Please put in ${cola.Cost}");
//    selection = cola;
//}
//else if (choice == 2)
//{
//    Console.WriteLine($"Please put in ${rootBeer.Cost}");
//    selection = rootBeer;
//}