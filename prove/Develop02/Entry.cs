public class Entry
{
    public DateTime _theCurrentTime;
    public string _dateText;
    public string _response;
     // Constructor to initialize the entry. I KEEP FORGETTING TO ADD THIS!!! 
    public Entry()
    {
        _theCurrentTime = DateTime.Now; 
        _dateText = _theCurrentTime.ToShortDateString(); 
        _response = ""; 
    }

    public void Enter()
    {
        _response = Console.ReadLine();
    }

}