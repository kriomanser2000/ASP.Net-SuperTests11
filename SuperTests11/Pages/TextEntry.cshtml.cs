using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SuperTests11.Pages
{
    public class TextEntryModel : PageModel
    {
        public IList<Question> Questions => Data.TextEntryQuestions;
        [BindProperty]
        public string[] Answers { get; set; }
        public IActionResult OnPostFinish()
        {
            int singleChoiceScore = TempData.ContainsKey("SingleChoiceScore") ? (int)TempData["SingleChoiceScore"] : 0;
            int multipleChoiceScore = TempData.ContainsKey("MultipleChoiceScore") ? (int)TempData["MultipleChoiceScore"] : 0;
            var result = new TestResult
            {
                UserId = 1,
                SingleChoiceScore = singleChoiceScore,
                MultipleChoiceScore = multipleChoiceScore,
                TextEntryAnswers = Questions.Select((q, i) => new TextEntryAnswer { QuestionId = q.Id, UserAnswer = Answers[i] }).ToList()
            };
            return RedirectToPage("./Results", new { result });
        }
    }
}