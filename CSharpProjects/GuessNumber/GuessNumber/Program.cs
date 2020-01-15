using System;

//Namespace

namespace GuessNumber
{
    //Main Class
    class Program
    {
        //Entry point method
        static void Main(string[] args)
        {
            //Display App Info
            GetAppInfo();

            //Greet the user
            GreetTheUser();

            while (true)
            {
                //create a new random object
                Random random = new Random();

                //init correct number
                //int correctNumber = 7;
                int correctNumber = random.Next(1, 10);

                // init guees var
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    // guess user's input
                    string input = Console.ReadLine();

                    // make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number!");

                        //keep going
                        continue;
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again !");

             
                    }

                }

                //output success message
                PrintColorMessage(ConsoleColor.Green, "You are CORRECT !");

               
                //ask to play again
                Console.WriteLine("Play Again ? [Y/N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }

            }

        }

        // Get App Info
        static void GetAppInfo()
        {
            //set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "KH";

            // change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // write out app info
            Console.WriteLine("Welcome to {0} : Version {1} by {2}", appName, appVersion, appAuthor);

            // reset text color
            Console.ResetColor();
        }
        //Greet the User
        static void GreetTheUser()
        {
            // ask user's name
            Console.WriteLine("What is your name ? ");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game :D ", inputName);
        }
        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // change text color
            Console.ForegroundColor = color;

            // write error message
            Console.WriteLine(message);

            // reset text color
            Console.ResetColor();
        }
    }
}
