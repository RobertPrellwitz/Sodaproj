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
        public void ChooseSoda()
        {
            Console.WriteLine($"Please select your soda\n 1 for Cola\n" +
                $"\n2 for Root Beer\n3 for Orange Soda ");
            int choice;
            bool check = Int32.TryParse(Console.ReadLine(), out choice);
            if (check)
            {
                if (choice == 1)
                {
                    Console.WriteLine($"Please put in ${cola.Cost}");
                    selection = cola;
                }
                else if (choice == 2)
                {
                    Console.WriteLine($"Please put in ${rootBeer.Cost}");
                    selection = rootBeer;
                }

                else if (choice == 3)
                {
                    Console.WriteLine($"Please put in ${orange.Cost}");
                selection = orange;
            }
            else
            {
                ChooseSoda();
            }
        }

        }
        public void MakePayment()
        {
            payment = new List<Coin>();
            walletobj.CurrentChange();
            // console selection options 1 penny 2 nickel 3 dime 4 quarter
            int choice;
            bool check = Int32.TryParse(Console.ReadLine(), out choice);
            if (check)
            {
                if (choice == 1)
                {
                    payment.Add(new Penny());
                }
                if (choice == 2)
                {
                    payment.Add(new Nickel());
                }
                if (choice == 2)
                {
                    payment.Add(new Dime());
                }
                if (choice == 4)
                {
                    payment.Add(new Quarter());
                }
                else
                {
                    MakePayment();
                }
            }



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