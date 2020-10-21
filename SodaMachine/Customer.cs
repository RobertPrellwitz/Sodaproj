using System;
using System.Collections.Generic;
namespace SodaMachine
{
    public abstract class Customer
    {
        public Can selection;
        public BackPack pack;
        //public Coin coin;

        public Customer()
        {

            Cola cola = new Cola();
            RootBeer rootBeer = new RootBeer();
            Orange orange = new Orange();

        }
        public void ChooseSoda(Cola cola, Orange orange, RootBeer rootBeer)
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
            }
        
        }
        public void MakePayment()
        {

        }

        public void AddToBackPack()
        {
            pack.sodas.Add(selection);
        }
    }

}
