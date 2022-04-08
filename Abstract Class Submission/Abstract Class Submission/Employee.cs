using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Submission
{
    class Employee: Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + lastName);
        }
    }
}
