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
            Console.WriteLine("Thesee are the employees with a first name of 'Joe':");


            foreach (Employee employees in listing.Employees)
            {
                List<string> empty = new List<string>();
                if (employees.FirstName == "Joe")
                {
                    empty.Add(employees.FirstName + employees.LastName);
                    for (int i = 0; i < empty.Count; i++)
                    {
                        Console.WriteLine(empty[i]);
                    }
                }
            }
            Console.WriteLine("\n\nThesee are the employees with a first name of 'Joe' using a lambda expression: ");

            foreach (Employee employee1 in listing.Employees.Where(x => x.FirstName.Contains("Joe")))
            {
                List<string> empty1 = new List<string>();
                empty1.Add(employee1.FirstName + employee1.LastName);
                for (int i = 0; i < empty1.Count; i++)
                {
                    Console.WriteLine(empty1[i] );
                }
            }
            
            //gets the employees with an id greather than 5
            Console.WriteLine("\n\nEmployee with an Id greather than 5: \n");
            foreach (Employee employee in listing.Employees.FindAll(x => x.Id > 5))
            {
                
                Console.WriteLine( "First Name: " + employee.FirstName + " \nLast Name: " + employee.LastName + "\n");
            }


            Console.ReadLine();
            
        }

    }
}
