public class Comment
{
    string _commenterName;
    string _commenterText;

    public Comment(string commenterName, string commenterText)
    {   
        _commenterName = commenterName;
        _commenterText = commenterText;

        FormatComment();

    }
    public string FormatComment()
    {
        return ($"\n{_commenterName}: {_commenterText}"); 

    }
}
