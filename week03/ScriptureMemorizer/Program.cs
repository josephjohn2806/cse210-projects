using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var library = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding"),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son"),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me")
        };

        Random rnd = new Random();
        Scripture scripture = library[rnd.Next(library.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            
            string input = Console.ReadLine();
            if (input.ToLower() == "quit" || scripture.IsCompletelyHidden())
                break;

            scripture.HideRandomWords(3);
        }
    }
}
