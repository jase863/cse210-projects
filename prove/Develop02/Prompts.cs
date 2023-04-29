public class Prompts
{
    List<string> _prompts = new List<string>() {"What is something that made you smile today?",
    "Did anything funny happen?",
    "How did the Lord speak to you?",
    "Did you do anything fun?",
    "What was your favorite conversation you had?",
    "What did you do for someone else today?"};

    public string Generator()
    {
        Random Generator = new Random();
        int randomIndex = Generator.Next(0, _prompts.Count);
        
        return _prompts[randomIndex];
    }
}
