using System;

class Program
{
    static void Main()
    {
        // An array that has the possible scriptures
        Scripture[] scriptures = new Scripture[]
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), 
                "Trust in the Lord with all thine heart, and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            
            new Scripture(new Reference("John", 3, 16), 
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            
            new Scripture(new Reference("Philippians", 4, 13), 
                "I can do all things through Christ which strengtheneth me."),

            new Scripture(new Reference("Moroni", 10, 4, 5), 
                "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."),

            new Scripture(new Reference("Doctrine and Covenants", 10, 5), 
                "Pray always, that you may come off conqueror, yea, that you may conquer Satan, and that you may escape the hands of the servants of Satan that do uphold his work.")
        };

        // The part that actualy gets the random scripture
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Length)];


        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetRenderedText());
                Console.WriteLine("\nAll words are hidden. Memorization complete!");
                break;
            }
        }
    }
}
