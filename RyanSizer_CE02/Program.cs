using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanSizer_CE02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ryan Sizer
            Section 01
            Advanced Scalable Data Infrastructures
            06/04/2017
            Bank Terminal
            */

            //Greet user
            Console.WriteLine("Welcome to the Bank Terminal.");
            Console.WriteLine();

            //Create do while loop to keep program running until user chooses to quit
            do
            {

                //Create a menu with five possible selections for the user
                Console.WriteLine();
                Console.WriteLine("BANK OF CLEVELAND");
                Console.WriteLine("\r\n\r\nPlease make a selection:");
                Console.WriteLine("1 - Create customer");
                Console.WriteLine("2 - Create account");
                Console.WriteLine("3 - Set account balance");
                Console.WriteLine("4 - Display account balance");
                Console.WriteLine("5 - QUIT");
                Console.WriteLine();
                Console.Write("> ");

                //Declare int variable for user menu selection 
                int menuChoice;

                //Capture the user response and store it in a string variable
                string menuChoiceString = Console.ReadLine();

                //Make sure that user enters a number for the menu choice
                //Create a conditional to test out validation of the problem
                while (!(int.TryParse(menuChoiceString, out menuChoice)))
                {
                    //Tell user what went wrong and that it was unable to convert
                    Console.WriteLine("Oops! You typed in something other than the corresponding menu choice number of 1 through 5.\r\nPlease input your number selection and press enter:");

                    //Re-capture the user response
                    menuChoiceString = Console.ReadLine();

                    //Re-convert captured string response to an integer
                    int.TryParse(menuChoiceString, out menuChoice);

                }

                while (menuChoice < 1 || menuChoice > 5)
                {
                    //Tell user what went wrong and that it was unable to proceed
                    Console.WriteLine("Oops! You typed in a number that does not correspond to the menu choice numbers of 1 through 5.\r\nPlease input your number selection and press enter:");

                    //Re-capture the user response
                    menuChoiceString = Console.ReadLine();

                    //Re-convert captured string response to an integer
                    int.TryParse(menuChoiceString, out menuChoice);
                }



            } while (true);
        }

    }
}
