using System;

namespace Class_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods operation = new Methods();

            int i;
            //asking user for input
            Console.WriteLine("Please choose a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = Methods.Adding(out i);
            //calling the class
            Methods.MathOperations(number, number2 );
        }
    }
}
