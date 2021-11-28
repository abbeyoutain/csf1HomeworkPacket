using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csf1Homework
{
    class ATMApplication
    {
        static void Main(string[] args)
        {

            bool correctAccount = false;
            int accountAttempts = 1;

            do
            {

                Console.WriteLine("Enter account number: ");
                string account = Console.ReadLine();

                if (account == "1234")
                {
                    correctAccount = true;
                }//end if

                if (correctAccount)
                {
                    bool correctPin = false;
                    int pinAttempts = 1;

                    do
                    {
                        Console.WriteLine("Enter pin number: ");
                        string pin = Console.ReadLine();

                        if (pin == "4321")
                        {
                            correctPin = true;

                            bool repeat = true;
                            do
                            {
                                Console.WriteLine(@"
D) Deposit
W) Withdrawal
E) Exit
");
                                string userChoice = Console.ReadLine().ToLower();

                                switch (userChoice)
                                {
                                    case "d":
                                    case "deposit":
                                        Console.Write("How much do you want to deposit?\nEnter amount: ");
                                        decimal deposit = Convert.ToDecimal(Console.ReadLine());
                                        Console.WriteLine($"{deposit:c} has been deposited into account 1234.\n\n" +
                                            $"Do you want to make another deposit, a withdrawal, or exit the applicatoin?");
                                        break;
                                    
                                    case "w":
                                    case "withdrawal":
                                        Console.Write("How much do you want to withdraw?\nEnter amount: ");
                                        decimal withdrawal = Convert.ToDecimal(Console.ReadLine());
                                        Console.WriteLine($"{withdrawal:c} has been withdrawn from account 1234.\n\n" +
                                            $"Do you want to make another withdrawal, a deposit, or exit the applicatoin?");
                                        break;

                                    case "e":
                                    case "exit":
                                        Console.WriteLine("\nThank you for your business.");
                                        repeat = false;
                                        break;
                                    
                                    default:
                                        Console.WriteLine("Invalid option.");
                                        break;
                                }//end switch
                            } while (repeat);

                        }//end if

                        else
                        {
                            Console.WriteLine("Incorrect pin number.");
                            pinAttempts += 1;
                            Console.WriteLine("\nUsed all attempts. Try again later.");
                        }
                    } while (correctPin == false && pinAttempts <= 3);

                }//end if

                else
                {
                    Console.WriteLine("Incorrect account number.");
                    accountAttempts += 1;
                }//end if

            } while (correctAccount == false && accountAttempts <= 3);

        }//end svm
    }//end class
}//end namespace
