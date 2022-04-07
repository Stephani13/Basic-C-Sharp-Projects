using System;
using System.Collections.Generic;

namespace Array_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array for string an one for integers
            string[] stringArray = new string[] { "hello", "world", "this", "is", "an", "array" };

            int[] numArray = new int[] { 2, 3, 10, 200, 300, 0 };
            //ask user to chose a number to use as an index
            Console.WriteLine("Please chose an index:");
            int index = Convert.ToInt32(Console.ReadLine());
            //use a while loop to get to an index acceptable
            while (index > 5)
            {
                Console.WriteLine("This index is bigger than the number of items in the array! Please chose a number from 0 to 5.");
                Console.WriteLine("Please chose an index:");
                index = Convert.ToInt32(Console.ReadLine());
            }
            //print the item for that index
            Console.WriteLine("The item that belongs to that index in the arrays are: " + "\n" + stringArray[index] + "\n" + numArray[index]);


            List<string> stringList = new List<string> {"This ", "Is", "A", "String", "List" };
            Console.WriteLine("Please chose an index:");
            int index2 = Convert.ToInt32(Console.ReadLine());

            while(index2 > 4)
            {
                Console.WriteLine("This index is bigger than the number of items in the array! Please chose a number from 0 to 4.");
                Console.WriteLine("Please chose an index:");
                index2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The item that belongs to that index in the list is: " + stringList[index2]);


            Console.ReadLine();
        }
    }
}
