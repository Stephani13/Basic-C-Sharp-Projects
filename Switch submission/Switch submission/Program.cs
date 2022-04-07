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
            //set yellow as the correct answer
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





            Console.WriteLine("Guess the number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isNumber = number == 1;

            while (!isNumber)
            {
                switch (number){
                    case 1:
                        Console.WriteLine("You guessed the write number");
                        isNumber = true;
                        break;

                    default:
                        Console.WriteLine("That is the wrong number.Try again");
                        Console.WriteLine("Guess the number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            Console.ReadLine();
        }
    }
}
