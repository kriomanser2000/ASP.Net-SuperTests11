using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SuperTests11.Pages
{
    public class ResultsModel : PageModel
    {
        public TestResult Result { get; set; }
        public IList<Question> Questions => Data.TextEntryQuestions;
        public void OnGet(TestResult result)
        {
            Result = result;
        }
    }
}