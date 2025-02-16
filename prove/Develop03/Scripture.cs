

class Scripture
{
    private Reference _reference;
    private Word[] _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitText = text.Split(' ');
        _words = new Word[splitText.Length];

        for (int i = 0; i < splitText.Length; i++)
        {
            _words[i] = new Word(splitText[i]);
        }
    }

    public void HideWords(int count)
{
    int hiddenCount = 0;
    int remainingWords = _words.Count(w => !w.IsHidden()); // Count unhidden words

    while (hiddenCount < count && remainingWords > 0)
    {
        int index = _random.Next(_words.Length);

        if (!_words[index].IsHidden())
        {
            _words[index].Hide();
            hiddenCount++;
            remainingWords--; // Decrease remaining words count
        }

        // If the remaining words are less than the requested count, just hide all of them
        if (remainingWords == 0)
            break;
    }
}


    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetRenderedText()
    {
        string renderedText = _reference.GetReference() + "\n";
        foreach (Word word in _words)
        {
            renderedText += word.GetRenderedText() + " ";
        }
        return renderedText.Trim();
    }
}
