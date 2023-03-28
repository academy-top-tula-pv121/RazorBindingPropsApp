using Microsoft.AspNetCore.Mvc;

namespace RazorBindingPropsApp
{
    public class Employee
    {
        [BindProperty(Name = "name")]
        public string FullName { set; get; }
        [BindProperty(Name = "age")]
        public int TotalAge { set; get; }
    }
}
