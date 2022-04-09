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





            //use lambda to get employees with a first name of Joe
            List<Employee> newList = listing.Employees.FindAll(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("Thesee are the employees with a first name of 'Joe':\n");
            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee);
            }

            foreach (Employee employee in listing.Employees.FindAll(x => x.FirstName == "Joe"))
            {
                
            }




            //gets the employees with an id greather than 5
            Console.WriteLine("Employee with an Id greather than 5: \n");
            foreach (Employee employee in listing.Employees.FindAll(x => x.Id > 5))
            {
                
                Console.WriteLine( "First Name: " + employee.FirstName + " \nLast Name: " + employee.LastName + "\n");
            }


            Console.ReadLine();
            
        }

    }
}
