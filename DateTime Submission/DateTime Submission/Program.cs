using System;

namespace DateTime_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the current day and time
            Console.WriteLine(DateTime.Now);
            //ask user for input and stores it in a int type variable
            Console.WriteLine("Please, Choose  number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //displays to the console the time it will be in an X number of hours, X being the variable number 
            //defined by the user
            Console.WriteLine(DateTime.Now.AddHours(number));
        }
    }
}
