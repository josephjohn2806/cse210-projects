using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        if (score >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (score >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }
    }
}