using System;

namespace Operators_Submission
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee();
            employee1.Id = 1012;


            Employee employee2 = new Employee();
            employee2.Id = 1021;

            Console.WriteLine("Is employee1 the same as employee2 id?");
            Console.WriteLine(employee1 == employee2);
            
            

        }
    }
}
