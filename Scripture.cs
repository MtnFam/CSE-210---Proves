using System;

// Handles the Scripture object, keeping track of both the Reference and the Passage.
public class Scripture
{
    private Reference _reference;
    private Passage _passage;
    
    // Creates a new instance of the Scripture class using the reference and passage parameters
    public Scripture(Reference reference, Passage passage)
    {
        _reference = reference;
        _passage = passage;
    }

    // Calls the hideWords function from Passage (not directly manipulating the words).
    public void HideWords(int countToHide)
    {
        _passage.HideWords(countToHide);
    }

    // Makes sure all of the words have been hidden
    public bool IsAllHidden()
    {
        return _passage.IsAllHidden();
    }

    /// Formats the complete scripture for display in the console view.
    public override string ToString()
    {
        return $"{_reference.ToString()}\n{_passage.ToString()}";
    }
}