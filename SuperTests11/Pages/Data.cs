namespace SuperTests11.Pages
{
    public class Data
    {
        public static List<Question> SingleChoiceQuestions = new List<Question>
        {
            new Question
            {
                Id = 1,
                Text = "Яка столиця України?",
                Answers = new List<Answer>
                {
                    new Answer { Id = 1, Text = "Київ", IsCorrect = true },
                    new Answer { Id = 2, Text = "Львів", IsCorrect = false },
                    new Answer { Id = 3, Text = "Харків", IsCorrect = false }
                },
                Type = QuestionType.SingleChoice
            },
        };
        public static List<Question> MultipleChoiceQuestions = new List<Question>
        {
            new Question
            {
                Id = 11,
                Text = "Які кольори є на прапорі України?",
                Answers = new List<Answer>
                {
                    new Answer { Id = 11, Text = "Жовтий", IsCorrect = true },
                    new Answer { Id = 12, Text = "Синій", IsCorrect = true },
                    new Answer { Id = 13, Text = "Червоний", IsCorrect = false }
                },
                Type = QuestionType.MultipleChoice
            },
        };
        public static List<Question> TextEntryQuestions = new List<Question>
        {
            new Question
            {
                Id = 21,
                Text = "Назвіть столицю Франції",
                Answers = null,
                Type = QuestionType.TextEntry
            },
        };
    }
}