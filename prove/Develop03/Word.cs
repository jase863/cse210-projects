public class Word
{   
    // member varialbe for each word of the verse
    private string _word;

    // boolean for hiding words
    private bool _hidden;

    // constructor for Word class
    public Word(string word)
    {
        _word = word;
    }

    public bool GetHidden()
    {
        return _hidden;
    }

    // sets the given word as hidden, as constituted by the scripture class 
    public void SetHidden(bool hidden)
    {
        _hidden = hidden;
    }

    // returns the value of _word
    public string GetWord()
    {
        return _word;
    }
}
