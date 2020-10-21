using System;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            Wallet trifold = new Wallet();
            Console.WriteLine($"you have {trifold.totalWallet} in your wallet" );
            trifold.CurrentChange();

            SodaMachine machine = new SodaMachine();
            //machine.MachineChange();
            //machine.MachineStock();
            machine.CurrentInventory();



            

        }
    }
}
