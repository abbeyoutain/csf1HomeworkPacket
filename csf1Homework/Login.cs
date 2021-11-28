using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csf1Homework
{
    class Login
    {
        static void Main(string[] args)
        {

            bool isAdmin = false;
            int attempts = 1;

            do
            {

                Console.WriteLine("Enter your username: ");
                string userName = Console.ReadLine().ToLower();

                if (userName == "abbey" || userName == "admin")
                {
                    isAdmin = true;
                }//end if

                if (isAdmin)
                {
                    bool correctPassword = false;
                    int passwordAttempts = 1;

                    do
                    {
                        Console.WriteLine("You have access.\nEnter password: ");

                        string password = Console.ReadLine().ToLower();

                        if (password == "outain" || password == "admin")
                        {
                            correctPassword = true;
                            Console.WriteLine("You are logged in.");
                        }//end if

                        else
                        {
                            Console.WriteLine("Incorrect password");
                            passwordAttempts += 1;
                        }
                    } while (correctPassword == false && passwordAttempts <= 3);

                }//end if

                else
                {
                    Console.WriteLine("You do not have access.");
                    attempts += 1;
                }//end if

            } while (isAdmin == false && attempts <= 3);

            Console.WriteLine("\nExiting application.");

        }//end svm
    }//end class
}//end namespace
