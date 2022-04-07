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

            float multiplyResult = Mathoperation.MathOperation(3.99f, 1.5f);
            Console.WriteLine(multiplyResult);

            string resultSubstract = Mathoperation.MathOperation("2", "33");
            int resultsubstract = Convert.ToInt32(resultSubstract);
            Console.WriteLine(resultsubstract);
        }
    }
}
