using System.Text;
using System;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "My brother ";
            string two = "liam";
            string three = ", he is 4 years old."
            StringBuilder sb = new StringBuilder();


            sb.Append("name is: ");
            two = two.ToUpper();
            Console.WriteLine(one + sb + two + three );
            Console.ReadLine();
        }
    }
}
