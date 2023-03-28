using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorBindingPropsApp.Pages
{
    public class IndexModel : PageModel
    {
        //[BindProperty(Name = "name")]
        //public string FullName { set; get; }

        //[BindProperty(Name = "age")]
        //public int TotalAge { set; get; }

        [BindProperty(SupportsGet = true)]
        public Employee Employee { get; set; }

        public string AnswerInfo { set; get; }

        public IndexModel()
        {

        }

        //public void OnGet()
        //{
        //    AnswerInfo = "Input User Values:";
        //}
        //public void OnPost()
        //{
        //    AnswerInfo = $"Name: {Employee.Name}, Age: {Employee.Age}";
        //}
    }
}