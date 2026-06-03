class WritingAssignment : Assignment
{
    private string _title;
    public string GetHomeworkList()
    {
        string studentName = GetStudentName();
        return $" {_title} by {studentName}";
    }
    public WritingAssignment(string title, string name, string topic) : base (name, topic)
    {
        _title = title;
    }
}