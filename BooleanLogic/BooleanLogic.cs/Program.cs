using System;

namespace BooleanLogic.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string ageString = Console.ReadLine();
            //Convert user input to integer
            int age = Convert.ToInt32(ageString);


            Console.WriteLine("Have you ever had a DUI?\nPlease enter true or false.");
            string trueOrFalseString = Console.ReadLine();
            bool trueOrFalse = Convert.ToBoolean(trueOrFalseString);

            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTicketString = Console.ReadLine();
            int speedingTicket = Convert.ToInt32(speedingTicketString);


            Console.WriteLine("Qualified?");

            Console.WriteLine(age > 15 && trueOrFalse == false && speedingTicket <= 3);
            Console.ReadLine();

            
        }
    }
}
