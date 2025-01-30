using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        int selection = 0;
        Journal journal = new Journal();

        while (selection != 6)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            string stringSelection = Console.ReadLine();
            try
            {
                selection = int.Parse(stringSelection);
            }
            catch
            {
            
            }

            if (selection == 1)
            {
                Entry entry = new Entry();
                entry._prompt = journal.DisplayPrompt();
                entry.Enter();
                journal.AddEntry(entry);
            }

            else if (selection == 2)
            {
                journal.DisplayEntries();
            }

            else if (selection == 3)
            {
                Console.Write("Enter the file name to load the journal: ");
                string fileName = Console.ReadLine(); // Get the file name from the user
                journal.LoadJournal(fileName);
            }

            else if (selection == 4)
            {
                Console.Write("Enter the file name to save the journal: ");
                string fileName = Console.ReadLine();
                journal.SaveJournal(fileName);
            }
            
            else if (selection == 5)
            {   
                Console.Write("Are you sure you want to delete the contents of this journal? (Y/N): ");
                string deleteResponse = Console.ReadLine().ToUpper();

                if (deleteResponse == "Y")
                {
                    journal.DeleteJournal();
                }
            }
            else{
                Console.WriteLine("Invalid selection. Please enter a number (1-6)");
            }
        }
    }
}