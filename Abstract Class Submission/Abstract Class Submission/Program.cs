using System;

namespace Abstract_Class_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee test = new Employee();
            test.firstname = "Sample";
            test.lastName = " Student";

            test.SayName();
        }
    }
}
