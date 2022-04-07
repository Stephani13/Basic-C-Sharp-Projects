using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Submission
{
    class Methods
    {
        public static void MathOperations(int number, int number3)
        {
            
            int result = (number - number3) / 2;
            Console.WriteLine("(" + number + " minus " + number3 + ") divided by 2 equals " + result);
        }

        public static int Adding(out int i)
        {
            i = 20;
            return i;
        
        }




    }
}
