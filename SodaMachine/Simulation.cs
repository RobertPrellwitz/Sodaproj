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
            sodaMachine = new SodaMachine();
            //BackPack patagoinia = new BackPack();
            //Wallet trifold = new Wallet();
        }

        public void Purchase()
        {
            
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


            Console.WriteLine("Please select which coins to use:\n1 penny \n2 nickel \n3 dime \n 4 quarter");
            customer.MakePayment();
            //customer.MakePayment();
            //customer.MakePayment();

            Console.WriteLine("you put the following in the machine");
            double total = 0;
            for (int i = 0; i < customer.payment.Count; i++)
            {
                Console.WriteLine(customer.payment[i].name);
                total = total + customer.payment[i].Value;
            }
            Console.WriteLine($"which totals :{total}");
           

            sodaMachine.ProcessPayment(customer);
            customer.walletobj.removeCoins();
            sodaMachine.MakeChange();
            

            customer.AddToBackPack();

            customer.walletobj.addCoins();



            sodaMachine.CurrentInventory();
            customer.walletobj.CurrentChange();
            //customer.BackPackContents();
        }
                






    }
}

