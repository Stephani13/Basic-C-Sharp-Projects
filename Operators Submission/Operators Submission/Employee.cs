﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Operators_Submission
{
    class Employee: Person
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + lastName);
        }

        public static bool operator == (Employee employee1, Employee employee2)
        {
            bool result = employee1.Id == employee2.Id;
            return result;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool result = employee1.Id != employee2.Id;
            return result;
        }

    }
}
