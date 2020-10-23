using System;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");


            Simulation Pepsi = new Simulation();
            //Pepsi.Purchase();
            Pepsi.BuySoda();
            Pepsi.Purchase();
            

        }
    }
}
