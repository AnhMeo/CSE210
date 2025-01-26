public class Entry
{   
    public DateTime theCurrentTime;
    public string _dateText;
    public string _response;
     // Constructor to initialize the entry. I KEEP FORGETTING TO ADD THIS!!! 
    public Entry()
    {
        theCurrentTime = DateTime.Now; 
        _dateText = theCurrentTime.ToShortDateString(); 
        _response = ""; 
    }

    
    public void Enter()
    {
        _response = Console.ReadLine();
    }

}