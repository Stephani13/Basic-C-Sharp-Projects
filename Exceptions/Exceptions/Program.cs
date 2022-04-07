using System;
using System.Collections.Generic;
namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //create a list of numbers
                List<int> numberList = new List<int>() { 3, 8, 6, 4, 90, 44, 33, 21 };
                Console.WriteLine("Please choose a number.");
                //ask for user input and use a loop to divide by the number chosen from the user
                int usernumber = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numberList.Count; i++)
                {
                    int result = numberList[i] / usernumber;
                    Console.WriteLine(result);
                }


            }
            catch(FormatException ex)
            {
                //if number is invalid then a message would display
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
