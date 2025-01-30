public class Entry
{
    public DateTime _theCurrentTime;
    public string _dateText;
    public string _response;
     // Constructor to initialize the entry below.
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