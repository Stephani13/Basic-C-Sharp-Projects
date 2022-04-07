using System;
using System.Collections.Generic;
using System.Text;

namespace Calling_Methods_Submission
{
    class Methods
    {
        //creating three methods that get passed a parameter
        public int AddingTwoNumbers(int number, int number2)
        {

            return number + number2;
        }

        public int MultiplyingTwoNumbers(int number, int number2)
        {
            return number * number2;
        }


        public int Square(int number, int number2)
        {
            //using the Math.Pow method to exponentiate one number to the power of the other
            int result = Convert.ToInt32(Math.Pow(number, number2));
            return result;
        }
    }

    
}
