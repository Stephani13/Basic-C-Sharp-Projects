using System;

namespace Method_part3_submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Method Operations = new Method();
            //creates to variables that holds the numbers
            int number1 = 10;
            int number2 = 29;
            //call method from class Method
            Method.MathOperation(number1, number2);
        }
    }
}
