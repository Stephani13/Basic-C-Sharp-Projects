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
            int number2 = operation.Adding(out i);
            
            //calling the class
            operation.MathOperations(number );
            operation.MathOperations(number, number2);

            Method1.method(number);
            
        }
    }
}
