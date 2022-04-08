using System;

namespace Parsing_Enums_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What day is today?");
                string day1 = Console.ReadLine();

                for (int i = 0; i < 7; i++)
                {
                    DaysOfTheWeek day = (DaysOfTheWeek)i;
                    
                }
                
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednestay,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
