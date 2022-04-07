using System;

namespace Calling_Methods_Submission
{
    class Program
    {
        public static void Main(string[] args)
        {
            //calling the methods for each equation
            Methods Addition = new Methods();

            //asking the user input
            Console.WriteLine("Please choose a number: ");
            int number = Convert.ToInt32(Console.ReadLine());


            //getting the user input and adding it to a fixed number
            int addingResult = Addition.AddingTwoNumbers(number, 30);
            Console.WriteLine(number + " + " + "30 " + "equals "  + addingResult);
            //getting the user input and multiplying it with the result
            int multiplyingResult = Addition.MultiplyingTwoNumbers(number, addingResult);
            Console.WriteLine(addingResult + " multiplied by " + number + " equals " + multiplyingResult);
            //getting the user input and the result of the multiplication squaring it with the input
            int squaringResult = Addition.Square( multiplyingResult, number);
            Console.WriteLine(multiplyingResult + " to the power of " + number + " equals " + squaringResult);

        }
    }
}
