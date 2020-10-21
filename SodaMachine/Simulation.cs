using System;
namespace SodaMachine
{
    public class Simulation
    {
       public SodaMachine sodaMachine;
        public Customer customer;
        public Quarter quarter;
        public Dime dime;
        public Nickel nickel;
        public Penny penny;
        public Cola cola;
        public Orange orange;
        public RootBeer rootBeer;

        public Simulation()
        {
            SodaMachine machine = new SodaMachine();
            BackPack patagoinia = new BackPack();
            Wallet trifold = new Wallet();
        }

        public void Purchase()
        {
            SodaMachine machine = new SodaMachine();
            BackPack patagoinia = new BackPack();
            Wallet trifold = new Wallet();

            Console.WriteLine($"you have {trifold.totalWallet} in your wallet");

            trifold.CurrentChange();
            Console.WriteLine($"you have the following in your backpack");
            patagoinia.BackPackContents();

            //machine.MachineChange();
            //machine.MachineStock();
            machine.CurrentInventory();

            customer.ChooseSoda();
            customer.MakePayment();

            machine.DepositPayment();
            trifold.removeCoins();
            machine.MakeChange();
            machine.DispenseProduct();

            patagoinia.AddToBackPack();

            trifold.addCoins();



            machine.CurrentInventory();
            trifold.CurrentChange();
            patagoinia.BackPackContents();
        }
                






    }
}

