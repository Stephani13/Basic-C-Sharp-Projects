using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Submission
{
    abstract class Person
    {
        public string firstname { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine("Name: " + firstname +lastName);
        }
    }
}
