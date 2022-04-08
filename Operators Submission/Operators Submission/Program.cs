using System;

namespace Operators_Submission
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee test = new Employee();
            int employee1 = test.Id = 113;
            int employee2 = test.Id = 114;

            bool result = Employee.Equals(employee1, employee2);
            Console.WriteLine(result);
            
            

        }
    }
}
