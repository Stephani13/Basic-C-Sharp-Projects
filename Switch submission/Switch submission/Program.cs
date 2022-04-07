using System;

namespace Switch_submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a color:");
            string color = Console.ReadLine();
            bool isColor = color == "yellow";

            do
            {
                switch(color) {
                    case "yellow":
                        Console.WriteLine("You guessed " + color + ". That is correct");
                        isColor = true;
                        break;

                    default:
                        Console.WriteLine("You guessed " + color + ". That is wrong. Try agaun.");
                        Console.WriteLine("Choose a color:");
                        color = Console.ReadLine();
                        break;

                }
            }

            while (!isColor);
            Console.ReadLine();
        }
    }
}
