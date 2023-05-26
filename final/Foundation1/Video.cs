public class Video
{
    public string _title = "";
    public string _author = "";
    public int _lengthInSeconds;
    public List<Comment> _commentsList = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds, Comment comment1, Comment comment2, Comment comment3, Comment comment4 = null)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _commentsList.Add(comment1);
        _commentsList.Add(comment2);
        _commentsList.Add(comment3);

        if (comment4 != null)
        {
            _commentsList.Add(comment4);
        }
    }

    public int CommentsNumber()
    {
        return _commentsList.Count();
    }
}
