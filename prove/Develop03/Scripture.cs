public class Scripture
{
    // list for storing each word in the verse
    private List<Word> _words = new List<Word>();

    // variable to hold the reference
    private Reference _reference;
    
    // list to hold verses to be chosen according to random verse chosen
    private List<string> scriptures = new List<string> {("If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him."), 
    ("And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them."),
    ("Pray always, that you may come off conqueror; yea, that you may conquer Satan, and that you may cescape the hands of the servants of Satan that do uphold his work."),
    ("No man can serve two masters: for either he will hate the one, and love the other; or else he will hold to the one, and despise the other. Ye cannot serve God and mammon."),
    ("Who shall ascend into the hill of the Lord? or who shall stand in his holy place?" + " He that hath clean hands, and a pure heart; who hath not lifted up his soul unto" + 
    " vanity, nor sworn deceitfully.")};

    // scripture constructor with reference as a parameter
    public Scripture(Reference reference)
    {   
        // setting value of _reference
        _reference = reference;

        // list to hold _words of verse
        _words = new List<Word>();

        // call to build our verse
        BuildVerse();
    }

    // method to get words and build a verse list using _words
    private void BuildVerse()
    {
        // list for getting each individual words ready for the main list
        List<string> verseText = scriptures[_reference.GetRandomInt()].Split(" ").ToList();

        // foreach loop for getting correctly separated words into _words list
        foreach (string textPart in verseText)
        {   
            // setting each word as a Word object in the Word class
            Word word = new Word(textPart);

            // add words to _words
            _words.Add(word);
        }
    }
    
    // getting and displaying text for the scripture
    public string GetText()
    {   
        // blank variable to later hold all words of the scripture
        string scriptureText = " ";
        
        foreach (Word data in _words)
        {
            // checking to see if words are already hidden
            if(data.GetHidden() == false)
            {
                // if not hidden, display the word and add a space. 
                scriptureText += data.GetWord() + " ";
            }
            else
            {
                // if hidden, display "_" for each letter in the word.
                scriptureText += new string('_', data.GetWord().Length) + " ";
            }
        }

        // returns the reference and the updated scripture text
        return ($"{_reference.BuildRef(_reference.GetRandomInt())} {scriptureText}");
    }

    // looks for remaining words
    public bool RemainingWords()
    {   
        // initially set to false so that it runs
        bool remaining = false;

        foreach (Word text in _words)
        {   
            if (text.GetHidden() == false)
            {
                // if the any isn't hidden, there are remaining words.
                remaining = true;
            }
        }

        return remaining;
    }

    // meat and potatoes
    public void HideWords()
    {   
        // option for how many words to remove
        Console.Write("\nHow many words would you like to remove? ");
        int amtToRemove = int.Parse(Console.ReadLine());

        // variable for number of removed words
        int schonRemoved = 0;

        do
        {
            // random index for which words to hide
            int zufallIdx = new Random().Next(0, _words.Count());

            // if the word isn't hidden...
            if (_words[zufallIdx].GetHidden() == false)
            {
                // ...make it hidden.
                _words[zufallIdx].SetHidden(true);
                
                // add amount already removed
                schonRemoved++;
            }
        
        // while the amount already removed does not equal the desired amonunt to be removed, and there are remaning words, keep looping.
        } while (schonRemoved != amtToRemove && RemainingWords() == true);
    }
}

