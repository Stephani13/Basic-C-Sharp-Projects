using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_submission
{
    class Program
    {
        public static void Main(string[] args)
        {
            Listing listing = new Listing();


            foreach (Employee employee in listing.Employees)
            {
                //Console.WriteLine(employee.FirstName + employee.LastName + " " + employee.Id);
            }
            //use lambda to get employees with a first name of Joe
            int count = listing.Employees.Count(x => x.FirstName == "Joe");

            Console.WriteLine("There are " + count + " employees with a first name of 'Joe'.\n");

            //gets the employees with an id greather than 5
            Console.WriteLine("Employee with an Id greather than 5: \n");
            foreach (Employee employee in listing.Employees.FindAll(x => x.Id > 5))
            {
                
                Console.WriteLine( "First Name: " + employee.FirstName + " \nLast Name: " + employee.LastName + "\n");
            }

            
        }

    }
}
