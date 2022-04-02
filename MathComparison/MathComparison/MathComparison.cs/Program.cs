using System;

namespace MathComparison.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("How much you get paid per hour?");
            string hourRateString = Console.ReadLine();
            Console.WriteLine("How many hours do you work per week?");
            string HoursworkedString = Console.ReadLine();

            decimal hourlyRate = Convert.ToDecimal(hourRateString);
            int hoursWorked = Convert.ToInt32(HoursworkedString); 


            Console.WriteLine("Person 2");
            Console.WriteLine("How much you get paid per hour?");
            string hourRateString2 = Console.ReadLine();
            Console.WriteLine("How many hours do you work per week?");
            string HoursworkedString2 = Console.ReadLine();


            decimal hourlyRate2 = Convert.ToDecimal(hourRateString2);
            int hoursWorked2 = Convert.ToInt32(HoursworkedString2);

            Console.WriteLine("Annual salary of Person 1:");
            decimal annualIncome = hourlyRate * hoursWorked * 52;
            Console.WriteLine(annualIncome);

            Console.WriteLine("Annual salary of Person 2:");
            decimal annualIncome2 = hourlyRate2 * hoursWorked2 *52;
            Console.WriteLine(annualIncome2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(annualIncome > annualIncome2);

            Console.ReadLine();
        }
    }
}
