namespace LiveCoding
{

public class Rpsls
{
    public enum Hand
    {
        Rock,
        Paper,
        Scissors,
        Lizard,
        Spock
    }

    Hand _hand;

    public Rpsls(Rpsls.Hand hand) {
        _hand = hand;
    }


    public override string ToString()
    {
        return _hand switch {
            Hand.Rock => "Rock",
            Hand.Paper => "Paper",
            Hand.Scissors => "Scissors",
            Hand.Lizard => "Lizard",
            Hand.Spock => "Spock",
            _ => "UNKNOWN"
        };
    }
}

}

//Figure out how to sort them AND what will happen if it can't be sorted

