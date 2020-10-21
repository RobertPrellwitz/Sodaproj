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
            customer = new Customer();
            // INSTANTIATE customer
            //SodaMachine machine = new SodaMachine();
            //BackPack patagoinia = new BackPack();
            //Wallet trifold = new Wallet();
        }

        public void Purchase()
        {
            sodaMachine = new SodaMachine();
            // BackPack patagoinia = new BackPack();
            //Wallet trifold = new Wallet();

            Console.WriteLine($"you have {customer.walletobj.totalWallet} in your wallet");

            customer.walletobj.CurrentChange();
            Console.WriteLine($"you have the following in your backpack");
           
            customer.pack.BackPackContents();
            //machine.MachineChange();
            //machine.MachineStock();
            sodaMachine.CurrentInventory();

            customer.ChooseSoda();
            customer.MakePayment();

            sodaMachine.DepositPayment();
            customer.walletobj.removeCoins();
            sodaMachine.MakeChange();
            sodaMachine.DispenseProduct();

            customer.AddToBackPack();

            customer.walletobj.addCoins();



            sodaMachine.CurrentInventory();
            customer.walletobj.CurrentChange();
            //customer.BackPackContents();
        }
                






    }
}

