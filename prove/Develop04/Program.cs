using System;

class Program
{
    static void Main()
    {
        DisplayMenu();
    }

    static void DisplayMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                if (choice == 4)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                
                StartActivity(choice);
            }
            else
            {
                Console.WriteLine("Invalid input. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }

    static void StartActivity(int choice)
    {
        Console.Write("Enter duration in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
        {
            switch (choice)
            {
                case 1:
                    new BreathingActivity(duration).RunActivity();
                    break;
                case 2:
                    new ReflectionActivity(duration).RunActivity();
                    break;
                case 3:
                    new ListingActivity(duration).RunActivity();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid duration. Press Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}
