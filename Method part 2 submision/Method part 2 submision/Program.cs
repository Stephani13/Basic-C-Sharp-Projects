using System;

namespace Method_part_2_submision
{
    class Program
    {
        static void Main(string[] args)
        {
            Method Operation = new Method();


            Console.WriteLine("Please choose a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose a second number. Press enter if you do not wish to enter one:");
            string number = Console.ReadLine();
            //an if statement in case the user does not insert a second number
            if (number == "")
            {
                int result = Operation.MathOperation(number1);
                Console.WriteLine(number1 + " multiplied by 5 equals " + result);
            }
            //otherwise replace the second number in the argument
            else
            {
                int number2 = Convert.ToInt32(number);
                int result = Operation.MathOperation(number1, number2);

                Console.WriteLine(number2 + " multiplied by " + number2 + " equals " + result);
            }

            Console.ReadLine();
        }
    }
}
