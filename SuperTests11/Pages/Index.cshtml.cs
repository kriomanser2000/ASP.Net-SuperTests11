using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SuperTests11.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Question> Questions => Data.SingleChoiceQuestions;
        [BindProperty]
        public int[] Answers { get; set; }
        public IActionResult OnPostNext()
        {
            int score = CalculateScore(Questions, Answers);
            TempData["SingleChoiceScore"] = score;
            return RedirectToPage("./MultipleChoice");
        }
        private int CalculateScore(IList<Question> questions, int[] answers)
        {
            int score = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Answers.Any(a => a.Id == answers[i] && a.IsCorrect))
                {
                    score++;
                }
            }
            return score;
        }
    }
}