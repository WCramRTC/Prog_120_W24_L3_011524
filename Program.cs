namespace Prog_120_W24_L3_011524
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boolean
            // bool
            // bool is a data type that holds either true or false


            // short cut for writeline
            // cw tab tab
            // Original: "Is it cold " + " isCold;
            // $"Is it cold {isCold}";

            // Condition
            // if statement

            // You put a boolean inside of these parenethese
            // true or false statement

            // Prompt the user if it is cold out
            Console.Write("Is it cold out? Enter 1 for yes, 2 for no");

            // Getting the users answer
            string userAnswer = Console.ReadLine();
            string isColdResponse = "1";
            string isNotColdResponse = "2";

            bool isItColdOut = userAnswer == isColdResponse;
            // When I typed "1" in as the user, it was saved to the userAnswer variable
            // Then userAnswer was compared to see if it was the same as "1"

            // declared but did not initialize
            // (didn't assign a value)
            bool isCold = false;

            // This if statement is changing our value from false to true if the user enters 1
            if (isItColdOut)
            {
                // if the user enters 1
                isCold = true;
            }

            // if - else if - else
            Console.WriteLine($"Is it cold out: {isCold}");

            // If FALSE, our if statement will never run
            // if / else if / else
            // If is cold ( user input is 1 )
            if (isCold == true) 
            {
                Console.WriteLine("Bring a jacket");
            }
            // If is not cold ( user input is 2 ) 
            else if (isCold == false)
            {
                Console.WriteLine("Wear some shorts");
            }
            else
            {
                Console.WriteLine("You didn't make a selection");
            }


            Console.WriteLine("After our if statement");


            //Console.WriteLine("Wear your shorts, it's hot out");


            // ---

            //// Parsing
            //// try catch
            //Console.Write("Enter the number 1: ");
            //string jakesInput = Console.ReadLine();
            //// try catch

            //try
            //{
            //    int jakesNumber = int.Parse(jakesInput);

            //    int doubleJakesNumber = jakesNumber + jakesNumber;

            //    Console.WriteLine($"Jakes New Number is {doubleJakesNumber}");
            //}
            //catch
            //{
            //    Console.WriteLine("Please enter a valid number.");
            //}




        }
    }
}
