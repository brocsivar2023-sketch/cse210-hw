using System.Runtime.InteropServices;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _author = author;
        _length = length;
        _title = title;
        _comments = new List<Comment>();
    }

    public void AddComments(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }
    public string Print()
    {
        int count = _comments.Count();
        return $"Title: {_title}, Author: {_author}, length (sec): {_length}, Number of comments: {count}";
    }
    public void PrintComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.Print());
        }
    }
}