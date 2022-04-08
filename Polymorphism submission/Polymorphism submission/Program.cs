using System;

namespace Polymorphism_submission
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee test = new Employee();
            test.firstname = "Sample";
            test.lastName = " Student";
            test.Quit();
            test.SayName();
        }
    }
}
