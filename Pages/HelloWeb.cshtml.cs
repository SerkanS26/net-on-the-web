using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using netOnTheWeb.Models;


namespace netOnTheWeb.Pages
{
    public class HelloWebModel : PageModel
    {
        public string Message { get; set; }

        public StudenstsList studenstsList = new StudenstsList();

        //public Student Serkan = new Student(1, "Serkan", 1);
        //public Student Selin = new Student(2, "Selin", 2);
        //public Student Esin = new Student(3, "Esin", 3);

        public void OnGet()
        {
            //Message = "In page Model: ";

        }


    }
}
