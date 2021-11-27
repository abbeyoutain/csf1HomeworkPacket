using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csf1Homework
{
    class TemperatureConverter
    {
        static void Main(string[] args)
        {
            decimal temperatureCelcius, temperatureFahrenheit;

            Console.Write("Enter a temperature in Celsius to convert it to Fahrenheit: ");
            temperatureCelcius = Convert.ToDecimal(Console.ReadLine()) * 9 / 5 + 32;

            Console.WriteLine($"{temperatureCelcius} degrees Fahrenheit");

            Console.Write("Enter a temperature in Fahrenheit to convert it to Celsius: ");
            temperatureFahrenheit = (Convert.ToDecimal(Console.ReadLine()) - 32) * 5 / 9;

            Console.WriteLine($"{temperatureFahrenheit} degrees Celcius");



            bool repeat = true;

            do
            {
                Console.WriteLine("F) Convert from Celcius to Fahrenheit.\nC) Convert from Fahrenheit to Celcius.\nX) To exit.");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "f":
                        Console.Write("Enter a temperature in Fahrenheit: ");
                        temperatureCelcius = Convert.ToDecimal(Console.ReadLine()) * 9 / 5 + 32;

                        Console.Write($"{temperatureCelcius} degrees Fahrenheit\nAnother conversion? Y/N: ");
                        if (Console.ReadLine().ToLower() == "y")
                        {
                            
                        }
                        else
                        {
                            repeat = false;
                        }
                        break;

                    case "c":
                        Console.Write("Enter a temperature in Celcius: ");
                        temperatureFahrenheit = (Convert.ToDecimal(Console.ReadLine()) - 32) * 5 / 9;

                        Console.WriteLine($"{temperatureFahrenheit} degrees Celcius\nAnother conversion? Y/N: ");
                        if (Console.ReadLine().ToLower() == "y")
                        {

                        }
                        else
                        {
                            repeat = false;
                        }
                        break;

                    case "x":
                        Console.WriteLine("Thank you.");
                        repeat = false;
                        break;
                        
                    default:
                        Console.WriteLine("That is not a valid option.\nAnother conversion?");
                        break;

                }//end switch

            } while (repeat);

        }//end svm
    }//end class
}//end namespace
