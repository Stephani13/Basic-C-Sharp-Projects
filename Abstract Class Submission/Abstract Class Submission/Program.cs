using System;

namespace Abstract_Class_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee test = new Employee();
            test.firstName = "Sample";
            test.lastName = " Student";

            test.SayName();
        }
    }
}
