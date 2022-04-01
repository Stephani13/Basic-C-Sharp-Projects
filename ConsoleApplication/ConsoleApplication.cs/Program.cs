using System;

namespace ConsoleApplication.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an integer:");
            string number = Console.ReadLine();
            long numberInput = Convert.ToInt64(number);

            Console.WriteLine(numberInput * 50 );

            Console.WriteLine(numberInput + 25);

            Console.WriteLine(numberInput / 12.5);

            Console.WriteLine(numberInput > 50);

            Console.WriteLine(numberInput % 7);

        }
    }
}
