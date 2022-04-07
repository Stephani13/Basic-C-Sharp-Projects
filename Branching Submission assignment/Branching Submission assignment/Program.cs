using System;

namespace Branching_Submission_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to package Express. Please follow the instructions bellow.");
            Console.WriteLine("What is the weight of the package?");

            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
                //if the weight is more than 50 the program would stop
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            //otherwise it will continue to ask for more information
            else
            {
                Console.WriteLine("What is the package width?");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package height?");
                int packageHeight = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("What is the package length?");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                int sum = packageHeight + packageLength + packageWidth;

                if (sum > 50)
                {
                    Console.WriteLine("package too big to be shipped via Package Express.");
                }
                else
                {
                    int quote = (packageHeight * packageLength * packageWidth * packageWeight) / 100;
                    Console.WriteLine("Your estimated total is: $" + quote +" \nThank you!");
                }


            }
            Console.ReadLine();
            
        }
    }
}
