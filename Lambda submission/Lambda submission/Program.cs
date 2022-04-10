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

            List<string> empty = new List<string>();
            foreach (Employee employees in listing.Employees)
            {
                
                if (employees.FirstName == "Joe")
                {
                    empty.Add(employees.FirstName + employees.LastName);
                    
                }
            }
            for (int i = 0; i < empty.Count; i++)
            {
                Console.WriteLine(empty[i]);
            }



            Console.WriteLine("\n\nThesee are the employees with a first name of 'Joe' using a lambda expression: ");

            List<Employee> emptylist = listing.Employees.Where(x => x.FirstName == "Joe").ToList();


            foreach (Employee employee1 in emptylist)
            {
                Console.WriteLine(employee1.FirstName + employee1.LastName);
            }
            
            //gets the employees with an id greather than 5
            Console.WriteLine("\n\nEmployee with an Id greather than 5: \n");
            List<Employee> greatherthan = listing.Employees.Where(x => x.Id > 5).ToList();


            foreach (Employee employee in greatherthan)
            {
                
                Console.WriteLine( "First Name: " + employee.FirstName + " \nLast Name: " + employee.LastName + "\n");
            }


            Console.ReadLine();
            
        }

    }
}
