namespace LiveCoding
{
    public class RpslsSorting
    {
        private static Dictionary<Rpsls.Hand, List<Rpsls.Hand>> _whatBeatsWhat = new()
        {
            { Rpsls.Hand.Rock, new List<Rpsls.Hand> { Rpsls.Hand.Scissors, Rpsls.Hand.Lizard } },
            { Rpsls.Hand.Paper, new List<Rpsls.Hand> { Rpsls.Hand.Rock, Rpsls.Hand.Spock } },
            { Rpsls.Hand.Scissors, new List<Rpsls.Hand> { Rpsls.Hand.Paper, Rpsls.Hand.Lizard } },
            { Rpsls.Hand.Lizard, new List<Rpsls.Hand> { Rpsls.Hand.Spock, Rpsls.Hand.Paper } },
            { Rpsls.Hand.Spock, new List<Rpsls.Hand> { Rpsls.Hand.Scissors, Rpsls.Hand.Rock } }
        };

        public static bool DoesHand1BeatHand2(Rpsls.Hand hand1, Rpsls.Hand hand2)
        {
                return _whatBeatsWhat[hand1].Contains(hand2);
        }

        
        public static List<Rpsls.Hand> SortHands(List<Rpsls.Hand> hands)
        {
            Dictionary<Rpsls.Hand, int> beatCounts = new Dictionary<Rpsls.Hand, int>();

            foreach (Rpsls.Hand hand in hands)
            {
                int count = 0;
                foreach (Rpsls.Hand otherHand in hands)
                {
                    if (DoesHand1BeatHand2(hand, otherHand))
                    {
                        count++;
                    }
                }

                beatCounts[hand] = count;
            }

            List<Rpsls.Hand> sorted = new List<Rpsls.Hand>(hands);

            for (int i = 0; i < sorted.Count - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < sorted.Count; j++)
                {
                    Rpsls.Hand handAtJ = sorted[j];
                    Rpsls.Hand handAtMax = sorted[maxIndex];

                    if (beatCounts[handAtJ] > beatCounts[handAtMax])
                    {
                        maxIndex = j;
                    }
                }

                if (maxIndex != i)
                {
                    Rpsls.Hand temp = sorted[i];
                    sorted[i] = sorted[maxIndex];
                    sorted[maxIndex] = temp;
                }
            }

            bool allSame = true;
            for (int i = 1; i < sorted.Count; i++)
            {
                if (sorted[i] != sorted[0])
                {
                    allSame = false;
                    break;
                }
            }

            if (allSame)
            {
                return hands;
            }

            return sorted;
        }


    }
}

