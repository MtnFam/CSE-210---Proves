using System;
using System.Collections.Generic;
using System.Linq;

public class Passage
{
    private List<Word> _words;
    
    public Passage(string text)
    {
        _words = new List<Word>();
        string[] splitWords = text.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideWords(int countToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0)
        {
            return;
        }

        int HiddenCount = 0;
        while (HiddenCount < countToHide && visibleWords.Count > 0)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
            HiddenCount++;
        }
    }

    public bool IsAllHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public override string ToString()
    {
        return string.Join(" ", _words.Select(w => w.ToString()));
    }
}
