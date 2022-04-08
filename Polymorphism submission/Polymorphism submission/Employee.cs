using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_submission
{
    class Employee: Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("I quit.");
        }
    }
}
