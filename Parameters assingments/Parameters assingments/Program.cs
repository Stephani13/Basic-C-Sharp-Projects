using System;
using System.Collections.Generic;

namespace Parameters_assingments
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>() { "paper", "stapler", "pen" };//create a list of strings
            //displays the objects on the list with a loop
            for (int i = 0; i < employee1.Things.Count; i++)
            {
                Console.WriteLine(employee1.Things[i]);
            }

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 200, 3000, 1000, 500 };//creates a list of integers

            for (int i = 0; i < employee2.Things.Count ; i++)
            {
                //prints the objects
                Console.WriteLine(employee2.Things[i]);
            }



        }
    }
}
