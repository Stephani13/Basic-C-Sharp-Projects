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
                string day2 = Console.ReadLine();
                string day1 = char.ToUpper(day2[0]) + day2.Substring(1);
                DaysOfTheWeek days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day1);

                Console.WriteLine(days);
             
                
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
