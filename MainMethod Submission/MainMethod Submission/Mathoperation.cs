﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethod_Submission
{
    class Mathoperation
    {
        //creates three math operaation methods to be called from main
        public static int MathOperation(int number1, int number2)
        {
            return number1 + number2;
        }

        public static decimal MathOperation(decimal number1, decimal number2)
        {
            decimal result = number1 * number2;
            return result;
        }

        public static int MathOperation(string string1, string string2)
        {
            //takes the strings and convert it to int to do a math operation

            int stringOne = Convert.ToInt32(string1);
            int stringTwo = Convert.ToInt32(string2);
            //Convert it back to string and return the value to the main function
            int result1 = stringOne - stringTwo;
           
            return result1;
        }

    }
}
