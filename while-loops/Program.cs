using System;

namespace while_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //        bool keepGoing = true; //line 3

            //        while (keepGoing)
            //        {
            //            Console.Write("Please enter a number: ");
            //            int firstNumber = Int32.Parse(Console.ReadLine());

            //            Console.Write("Please enter a number: ");
            //            int secondNumber = Int32.Parse(Console.ReadLine());

            //            int sum = firstNumber + secondNumber;

            //            Console.WriteLine($"The sum is: {sum}");

            //            Console.WriteLine("Would you like to find the sum of two different numbers? Enter (y)es or (n)o");
            //            string userInput = Console.ReadLine().ToLower();

            //        if (userInput == "n") 
            //    {
            //            keepGoing = false;
            //        }

            //    }

            //    Console.WriteLine("Press ENTER to exit");
            //Console.ReadLine();
            //ex ===============

            //Create an application that stores the value 0 in a variable called counter
            //Create a while loop that evaluates whether counter< 10
            //While the counter is less than ten
            //Print to the Console “The current value is: { counter}”
            //Add one to the counter
            //Run the program
            //What happens?

            //int counter = 0;
            //while (counter < 10) {
            //    Console.WriteLine($"The current value is: {counter}");
            //    counter++;
            //}



            //ex ===============
            //Create an application that stores the value 0 in a variable called counter
            //Create another variable called keepGoing
            //Create a while loop that evaluates whether keepGoing == “y”
            //While keepGoing == “y”
            //Print to the Console “The current value is: { counter}
            //Add one to the counter
            //Ask the user if they would like to continue
            //Store the user response in the keepGoing variable
            //Run the program
            //What happens?



            //int counter = 0;
            //string keepGoing;


            //while (keepGoing == "y")
            //{
            //    Console.WriteLine($"The current value is {counter}");
            //    counter++;
            //    Console.WriteLine("Would you like to continue?");
            //    keepGoing = Console.ReadLine();
            //}



            int counter = 0;
            string keepGoing;
            Console.WriteLine($"The current value is {counter}");
            Console.WriteLine("Would you like to continue?");
            keepGoing = Console.ReadLine();
            while (keepGoing == "y")
            {

                counter++;
                Console.WriteLine($"The current value is {counter}");
                Console.WriteLine("Would you like to continue?");
                keepGoing = Console.ReadLine();

            }
            if (keepGoing == "n") {
                Console.WriteLine("Press ENTER to exit");
                Console.ReadLine();}


            }
        }
}
