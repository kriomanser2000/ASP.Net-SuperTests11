using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SuperTests11.Pages
{
    public class MultipleChoiceModel : PageModel
    {
        public IList<Question> Questions => Data.MultipleChoiceQuestions;
        [BindProperty]
        public IList<int>[] Answers { get; set; }
        public IActionResult OnPostNext()
        {
            int score = CalculateScore(Questions, Answers);
            TempData["MultipleChoiceScore"] = score;
            int singleChoiceScore = TempData.ContainsKey("SingleChoiceScore") ? (int)TempData["SingleChoiceScore"] : 0;
            TempData["TotalScore"] = singleChoiceScore + score;
            return RedirectToPage("./TextEntry");
        }
        private int CalculateScore(IList<Question> questions, IList<int>[] answers)
        {
            int score = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                IEnumerable<int> correctAnswerIds = questions[i].Answers.Where(a => a.IsCorrect).Select(a => a.Id);
                if (answers[i].All(correctAnswerIds.Contains) && answers[i].Count == correctAnswerIds.Count())
                {
                    score++;
                }
            }
            return score;
        }
    }
}