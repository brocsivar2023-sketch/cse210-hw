class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string textbook, string problems, string name, string topic) : base (name, topic)
    {
        _textBookSection = textbook;
        _problems = problems;
    }
    public string GetMath()
    {
        string topic = GetTopic();
        string studentName = GetStudentName();
        return $" {topic} {studentName} {_textBookSection}, {"_problems"}";
    }
}