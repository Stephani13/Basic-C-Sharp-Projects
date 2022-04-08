using System;

namespace Polymorphism_submission
{
    class Program
    {
        static void Main(string[] args)
        {

            IQuittable test = new Employee();
            
            test.Quit();
            
        }
    }
}
