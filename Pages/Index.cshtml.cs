using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BMICalculator.Models;

namespace BMICalculator.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public BMIModel BMIData { get; set; }
        public BMIModel Result { get; set; }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Result = BMIData;
            }
        }
    }
}