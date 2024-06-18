using System;

namespace ATM
{
    class atm_check
    {
        public static void Main(string [] args)
        {
            int amount = 1000, deposit, withdraw;
            int choice;
            string pin="ABC";
            Console.WriteLine("Enter Your Pin: ");
            pin = Console.ReadLine();
            if(pin == "ABC")
            {            
                do
                {
                    Console.WriteLine("\n********Welcome to ATM Service**************\n");
                    Console.WriteLine("1. Check Balance\n");
                    Console.WriteLine("2. Withdraw Cash\n");
                    Console.WriteLine("3. Deposit Cash\n");
                    Console.WriteLine("4. Quit\n");
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("\nEnter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n YOUR CURRENT BANK BALANCE: "+amount+" Rs.");
                            break;
                        case 2:
                            Console.WriteLine("\n ENTER THE AMOUNT TO WITHDRAW: ");
                            withdraw = Convert.ToInt32(Console.ReadLine());;
                            if (withdraw % 100 != 0)
                            {
                            Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 100");
                            }
                            else if (withdraw > (amount - 500))
                            {
                            Console.WriteLine("\n INSUFFICENT BALANCE");
                            }
                            else
                            {
                            amount = amount - withdraw;
                            Console.WriteLine("\nPLEASE COLLECT THE CASH");
                            Console.WriteLine("\nYOUR CURRENT BALANCE IS: "+amount);
                            }
                            break;
                        case 3:
                            Console.WriteLine("\nENTER THE AMOUNT TO DEPOSIT");
                            deposit = Convert.ToInt32(Console.ReadLine());;
                            amount = amount + deposit;
                            Console.WriteLine("\nYOUR BALANCE IS: "+ amount);
                            break;
                        case 4:
                            Console.WriteLine("\n***************THANK YOU FOR USING ATM******************");
                        break;
                        default:
                            Console.WriteLine("\nChoose Correct Option!");
                            break;
                    }
                }while (choice!=4);
            }
            else
            {
                Console.WriteLine("\nINCORRECT PIN:(\n");
            }
        }
    }
}