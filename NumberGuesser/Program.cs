using System;
using System.IO;

//Namespace
namespace NumberGuesser //a container for classes and functions
{
    //Main Class
    internal class Program
    {
        static void Main(string[] args)
        {
            //Run App Info Function
            GetAppInfo();
            //Greet User 
            GreetUser();

            while(true)
            {
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 10);

                //Init guess var 
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10.");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    //Error handling for correct input type
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        //Tell user its the wrong data type
                        Console.WriteLine("Invalid input, please enter a number!");
                        //Reset text color
                        Console.ResetColor();

                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;
                        //Write out app info
                        Console.WriteLine("Wrong number, please try again");
                        //Reset text color
                        Console.ResetColor();
                    }
                    else
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Green;
                        //Write out winning message
                        Console.WriteLine("Congrats, you win! :)");
                        //Reset text color
                        Console.ResetColor();
                        //Ask user to play again
                        Console.WriteLine("Play Again? [Y or N]");

                        //Get answer
                        string answer = Console.ReadLine().ToUpper();
                        if (answer == "Y")
                        {
                            continue;
                        }
                        else if (answer == "N")
                        {
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }

        static void GetAppInfo()
        {
            // Set app vars 
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "David DAgostino";

            //Change the text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}! Let's play a game.", inputName);
        }
    }
}
