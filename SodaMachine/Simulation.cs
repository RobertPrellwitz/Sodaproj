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
            sodaMachine = new SodaMachine();
        }

        public void BuySoda()
        {
            int temp;
            do
            {
                UserInterface.Hello();
               
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
            UserInterface.Hello();

            int buy = UserInterface.CustomerSelectionCheck(sodaMachine);

            customer.ChooseSoda(sodaMachine.inventory, buy);

            UserInterface.WalletDisplay(customer, customer.walletobj);

            int type = UserInterface.PaymentType();

            if(type == 1)
            {
                CashPmt();
            }
            else
            {
                CreditPmt();
            }
            

        }
                
        public void CreditPmt()
        {
            sodaMachine.CreditTransaction(customer);
            customer.AddToBackPack();
            sodaMachine.CurrentInventory();
            sodaMachine.RegisterTotal();
            Console.WriteLine($" Credit purchases total {sodaMachine.creditPmtTotal}"); 
            customer.pack.BackPackContents();
        }


        public void CashPmt()
        {
            customer.MakePayment(customer.walletobj.coins);
            sodaMachine.ProcessTransaction(customer);
            customer.AddToBackPack();

            UserInterface.WalletDisplay(customer, customer.walletobj);
            sodaMachine.CurrentInventory();
            sodaMachine.RegisterTotal();
            customer.pack.BackPackContents();
        }




    }
}

