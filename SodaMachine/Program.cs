using System;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");


            Simulation Pepsi = new Simulation();

            //runs the basic soda machine and loops until user chooses stop
            Pepsi.BuySoda();

            // runs the soda machine with the credit card payment option (does not loop)
            Pepsi.Purchase();
            

        }
    }
}
