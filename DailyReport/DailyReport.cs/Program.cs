using System;

namespace DailyReport.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy."); ;
            Console.WriteLine("Student Daily Report.");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();


            Console.WriteLine("What course at you on?");
            string yourCourse = Console.ReadLine();


            Console.WriteLine("What page number?");
            string pageNumberString = Console.ReadLine();
            //Convert string to integer for page number
            int pageNumber = Convert.ToInt32(pageNumberString);

            Console.WriteLine("Dou you need help with anything?\nPlease answer true or false.");
            string needHelpString = Console.ReadLine();
            //Convert string to boolean true or false
            bool neeHelp = Convert.ToBoolean(needHelpString);

            Console.WriteLine("Were there any positive experiences you'd like to share?\nPlease give specifics");
            string positiveExperience = Console.ReadLine();


            Console.WriteLine("Is there any other feedback you'd like to provide>\nPlease give specific.");
            string feedback = Console.ReadLine();


            Console.WriteLine("How many hours did you study today?");
            string hoursTodayString = Console.ReadLine();
            //Converting the variable to integer
            int hoursToday = Convert.ToInt32(hoursTodayString);


            Console.WriteLine("Thank you for your answers.\nAn instructor will respond to this shortly.\nHave a great day!");

            Console.ReadLine();
        }
    }
}
