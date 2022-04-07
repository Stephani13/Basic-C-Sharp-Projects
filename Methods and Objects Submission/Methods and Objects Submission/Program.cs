using System;

namespace Methods_and_Objects_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee test = new Employee();
            //created a name uding employee class inheriting frrom person class
            test.FirstName = "Sample";
            test.LastName = " Student";
            //display everything using the sayName method from person class
            test.SayName();
        }
    }
}
