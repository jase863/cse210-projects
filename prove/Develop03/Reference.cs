public class Reference
{   
    // member variables for each element in the reference
    private string _book;
    private string _chapter;
    private string _verseOne;
    private string _verseTwo;

    // member variable for random integer chosen by SetRandomInt()
    private int _randomInt;

    // list of references
    private List<string> references = new List<string> {("James 1 5"), ("Moses 7 18"), ("D&C 10 5"), ("Matthew 6 24"), ("Psalm 24 3 4")};

    // sets the random integer for the index of the reference, as well as the index for the scripture
    private void SetRandomInt()
    {
        _randomInt = new Random().Next(0, references.Count());
    }

    // gets the private _randomInt member variable for use elsewhere in the program
    public int GetRandomInt()
    {
        return _randomInt;
    }

    // constructor for Referenc class
    public Reference()
    {   
        // call to get a random integer for the verse and scripture index
        SetRandomInt();

        // call to get a random reference
        BuildRef(GetRandomInt());
    }

    // builds a random reference with the provided index
    public string BuildRef(int _randomInt)
    {   

        // gets each part of the verse into a list that is easier to work with
        List<string> verses = references[_randomInt].Split(" ").ToList();


        foreach (string verse in verses)
        {   
            // if the reference only has one verse
            if (verses.Count() == 3)
            {
                _book = verses[0];
                _chapter = verses[1];
                _verseOne = verses[2];
            }
            else
            {
                _book = verses[0];
                _chapter = verses[1];
                _verseOne = verses[2];
                _verseTwo = verses[3];
            }
        }


        if (verses.Count() < 3)
        {
          // returns the format for one verse
          return ($"{_book} {_chapter}:{_verseOne}");  
        }

        else
        {
            // returns the format for multiple verses
            return ($"{_book} {_chapter}:{_verseOne} - {_verseTwo}");  
        }
    }
}
