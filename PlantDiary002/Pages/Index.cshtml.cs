using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PlantDiary002.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            String myName = "Nitheesha Daka";
            int age = 25;
            ViewData["MyName"] = myName;
            ViewData["age"] = age;
        }
    }
}
