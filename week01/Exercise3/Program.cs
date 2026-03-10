using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101); // number between 1 and 100
        int guess = -1;

        Console.WriteLine("Welcome to the Guess My Number Game!");

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
