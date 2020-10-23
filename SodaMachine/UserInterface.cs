using System;
namespace SodaMachine
{
   static class UserInterface
    {
        static UserInterface()
        {
        }

        
        public static void Hello()
        {
            Console.WriteLine("Welcome to the Soda Machine");
        }
        // soda choice selection check
        public static int BuyQuestion()
        {
            Console.WriteLine("\n\nWhat Soda would you like to buy today? \n1 = Cola \n2 = Root Beer\n3 = Orange Soda");
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

        public static int CustomerSelectionCheck(SodaMachine soda)
        {
            int choice = BuyQuestion();
            bool verify = soda.SelectionCheck(choice);
            if (verify == true)
            {
                return choice;
            }
            else
            {
                return CustomerSelectionCheck(soda);
            }
        }
        // method to display contents of wallet
        public static void WalletDisplay(Customer customer, Wallet wallet)
        {
            Console.WriteLine("You have the follwing available in your wallet");
            customer.walletobj.CurrentChange();
            customer.walletobj.TotalWallet();
            Console.WriteLine($"This creates a total of ${wallet.totalWallet}");
        }
        
        
        // check method for using more than one coin
        public static int inputCheck()
        {
            Console.WriteLine("would you like to add another coin? 1 for yes - 2 for no");
            int temp;
            bool checker = Int32.TryParse(Console.ReadLine(), out temp);
            if (checker && (temp == 1 || temp == 2))
            {
                return temp;
            }
            else
            {
                Console.WriteLine("invalid selection try again.");
                return inputCheck();
  
            }
        }
        //check method for coin input
        public static int CoinCheck()
        {
            Console.WriteLine("\nPlease select which coins to use:\n1 penny \n2 nickel \n3 dime \n4 quarter");
            int choice;
            bool check = Int32.TryParse(Console.ReadLine(), out choice);
            if (check && (choice == 1 || choice == 2 || choice == 3 || choice == 4))
            {
                return choice;
            }
            else
            {
                Console.WriteLine("invalid selection try again.");
                return CoinCheck();


            }
            
        }
        // check method for loop in simulation
        public static int runCheck()
        {
            int temp;
            bool checker = Int32.TryParse(Console.ReadLine(), out temp);
            if (checker && (temp == 1 || temp == 2))
            {
                return temp;
            }
            else
            {
                Console.WriteLine("invalid selection try again.");
                return runCheck();

            }
        }
    }
}
