using System;
namespace SodaMachine
{
   static class UserInterface
    {
        static UserInterface()
        {
        }

        // soda machine - available products  (Machine)
        public static void Hello()
        {
            Console.WriteLine("Welcome to the Soda Machine");
        }

        public static int BuyQuestion()
        {
            Console.WriteLine("What Soda would you like to buy today? \n1 = Cola \n2 = Root Beer\n3 = Orange Soda");
            int choice;
            bool check = Int32.TryParse(Console.ReadLine(), out choice);
            if (check)
            {
                if (choice == 1 || choice == 2 || choice == 3 )
                {
                    return  choice;
                }
                else
                {
                    Console.WriteLine("that is not a valid selection - please try again");
                    BuyQuestion();
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("that is not a valid selection - please try again");
                BuyQuestion();
                return 0;
            }
        }

        public static void WalletDisplay(Customer customer, Wallet wallet)
        {
            Console.WriteLine("You have the follwing available in your wallet");
            customer.walletobj.CurrentChange();
            customer.walletobj.TotalWallet();
            Console.WriteLine($"This creates a total of {wallet.totalWallet}");
        }
        // Input Money -  (consumer)
            // take money from wallet

        // Select Item - (consumer)
       

        // Verify Selection is available (machine)
            // if not available give option to select another or return money

        // process payment  (machine)

        // Dispense Product (machine)

        // Return change if any (machine)

        //  put item in backpac  (consumer)

        //
    }
}
