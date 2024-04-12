namespace SuperTests11.Pages
{
    public class Class2
    {
    }
    public class TestResult
    {
        public int UserId { get; set; }
        public int SingleChoiceScore { get; set; }
        public int MultipleChoiceScore { get; set; }
        public List<TextEntryAnswer> TextEntryAnswers { get; set; }
    }
    public class TextEntryAnswer
    {
        public int QuestionId { get; set; }
        public string UserAnswer { get; set; }
    }
}