using System;

namespace Constructor_Submission
{
    class Program
    {

        public Program(): this(25)
        {
            //this is refering to the same class, so with the this() method it actually 
            //executes the Program(int Age)
        }

        public Program(int Age)
        {
            //display variable to see the result
            Console.Write("Age is: " + Age);
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            //creates a costant
            const string name = "Massiel";
            var name1 = "Louisa";
        }
    }
}
