namespace SuperTests11.Pages
{
    public class Class1
    {
    }
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
        public QuestionType Type { get; set; }
    }
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
    public enum QuestionType
    {
        SingleChoice,
        MultipleChoice,
        TextEntry
    }
}