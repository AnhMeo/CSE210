public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public List<string> _prompts = new List<string>
    {
        "How did your day go?",
        "What are you grateful for today?",
        "What did you learn today?",
        "How are you feeling right now?",
        "What was the highlight of your day?",
        "What is one challenge you faced today, and how did you handle it?",
        "Describe a small moment today that made you smile.",
        "What is something you're looking forward to today, and why?",
        "How did you take care of yourself today?",
        "What was the most interesting conversation you had today?"
    };
    public Random _random = new Random();   
    public string DisplayPrompt()
    {
        string randomPrompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine(randomPrompt);
        return randomPrompt;
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Display all the journal entries
    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
            return;
        }

        foreach (var entry in _entries)
        {
            Console.WriteLine($"Date: {entry._dateText}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Response: {entry._response}");
            // Just to separate the entries from each other for readability
            Console.WriteLine("-------------");
        }
    }

    public void SaveJournal(string fileName)
    {
    
    using (StreamWriter writer = new StreamWriter(fileName))
    {
        // Iterate through all the journal entries and write them to the file.
        foreach (var entry in _entries)
        {
            writer.WriteLine($"Date: {entry._dateText}");
            writer.WriteLine($"Response: {entry._response}");
            writer.WriteLine("-------------");  // Separator between entries
        }
    }
    // Confirmation message!
    Console.WriteLine("Journal saved to file.");
    }

    public void LoadJournal(string fileName)
    {
        // Read all lines from the file into an array of strings
        string[] lines = File.ReadAllLines(fileName);
        Entry entry = null;

        foreach (var line in lines)
        {
            // Trim any extra spaces
            string trimmedLine = line.Trim();

            if (trimmedLine.StartsWith("Date:"))
            {
                // If we already have an entry, save it before creating a new one
                if (entry != null)
                {
                    _entries.Add(entry);
                }

                // Create a new entry and assign the date
                entry = new Entry();
                entry._dateText = trimmedLine.Substring(6); // Get the date after "Date: "
            }
            else if (trimmedLine.StartsWith("Response:"))
            {
                if (entry != null)
                {
                    entry._response = trimmedLine.Substring(10); // Get the response after "Response: "
                }
            }
        }

        // If there is an entry left after the loop, add it
        if (entry != null)
        {
            _entries.Add(entry);
        }
        // Confirmation message!
        Console.WriteLine("Journal loaded successfully.");
    }

    public void DeleteJournal()
{
    _entries.Clear(); // Clears the entries list
    // Confirmation message!
    Console.WriteLine("The journal has been cleared.");
}


}