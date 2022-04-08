using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Submission
{
    class Methods
    {
        public static void MathOperations(int number )
        {
            
            int result = number / 2;
            Console.WriteLine( number + " divided by 2 equals " + result);
        }

        public static void MathOperations(int number, int number2)
        {
            int results = number + number2;
            Console.WriteLine("By adding " + number + " + " + number2 +  " = " + results);
        }


        public static int Adding(out int i)
        {
            i = 20;
            return i;
        
        }




    }
}
