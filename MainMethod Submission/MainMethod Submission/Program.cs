using System;

namespace MainMethod_Submission
{
    class Program
    {
        public static void Main(string[] args)
        {
            //call on the methods and pass the arguments to be printed on the screen
            Mathoperation Addition = new Mathoperation();

            int addingResult = Mathoperation.MathOperation(30, 40);

            Console.WriteLine(addingResult);

            decimal multiplyResult = Mathoperation.MathOperation(3.99m, 1.5m);
            Console.WriteLine(multiplyResult);

            int resultSubstract = Mathoperation.MathOperation("2", "33");
            
            Console.WriteLine(resultSubstract);
        }
    }
}
