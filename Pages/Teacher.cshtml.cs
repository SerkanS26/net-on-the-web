using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using netOnTheWeb.Models;

namespace netOnTheWeb.Pages
{
    public class TeacherModel : PageModel
    {

        public TeachersList teachersList = new TeachersList(); 
    
        public void OnGet()
        {
        }
    }
}
