using System;

public class Scripture
{
    Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHidden = 0; 

        while (wordsHidden < numberToHide)
        {
            int index = random.Next(_words.Count);  

            if (!_words[index].IsHidden()) 
            {
                _words[index].Hide();
                wordsHidden++; 
            }

            if (IsCompletelyHidden()) break; 
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            displayText += " " + word.GetDisplayText();
        }
        return displayText;
    }
    
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}