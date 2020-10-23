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

        public void BuySoda()
        {
            int temp;
            do
            {
                UserInterface.Hello();
                //sodaMachine.CurrentInventory();
                int buy = UserInterface.CustomerSelectionCheck(sodaMachine);

                customer.ChooseSoda(sodaMachine.inventory, buy);

                UserInterface.WalletDisplay(customer, customer.walletobj);

                customer.MakePayment(customer.walletobj.coins);
                sodaMachine.ProcessTransaction(customer);
                customer.AddToBackPack();

                UserInterface.WalletDisplay(customer, customer.walletobj);
                sodaMachine.CurrentInventory();
                sodaMachine.RegisterTotal();
                customer.pack.BackPackContents();
                Console.WriteLine("Would you like to use the soda machine again?\n1 = yes \n2 = no");
                temp = UserInterface.runCheck();

            }
            while (temp == 1);
        }




        public void Purchase()
        {
            
            // BackPack patagoinia = new BackPack();
            //Wallet trifold = new Wallet();

            Console.WriteLine($"you have {customer.walletobj.totalWallet} in your wallet");

            customer.walletobj.CurrentChange();
            Console.WriteLine($"\nyou have the following in your backpack");
           
            customer.pack.BackPackContents();
            //machine.MachineChange();
            //machine.MachineStock();
            sodaMachine.CurrentInventory();

           

            //customer.ChooseSoda(sodaMachine.inventory);

            customer.walletobj.CurrentChange();

            Console.WriteLine("\nPlease select which coins to use:\n1 penny \n2 nickel \n3 dime \n4 quarter");
            customer.MakePayment(customer.walletobj.coins);
            
            Console.WriteLine("you put the following in the machine");
            double total = 0;
            for (int i = 0; i < customer.payment.Count; i++)
            {
                Console.WriteLine(customer.payment[i].name);
                total = total + customer.payment[i].Value;
            }
            Console.WriteLine($"which totals :{total}");
           

            sodaMachine.ProcessTransaction(customer);

            sodaMachine.CurrentInventory();            

            customer.AddToBackPack();

            //sodaMachine.TotalChange();

            //Console.WriteLine($"Your total change is: {Math.Round(sodaMachine.totalChange,2)}");


            //customer.AddToWallet(sodaMachine.changeCoins);



            sodaMachine.CurrentInventory();
            customer.walletobj.CurrentChange();
            //customer.BackPackContents();
        }
                






    }
}

