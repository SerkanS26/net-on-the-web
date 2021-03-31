using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using netOnTheWeb.Models;


namespace netOnTheWeb.Pages
{
    public class ClassModel : PageModel
    {
        public ClassesList classesList = new ClassesList();
        public TeachersList teachersList = new TeachersList();
        

        //public Class Lamarr = new Class(1, "Lamarr", new TeachersList().getTeacherFromList(0));
        //public Class Lamarr2 = new Class(2, "Lamarr2", new TeachersList().getTeacherFromList(1));
        //public Class Lamarr3 = new Class(3, "Lamarr3", new TeachersList().getTeacherFromList(2));

        

        public void OnGet()
        {
            classesList.setTeachers(teachersList);
        }
    }
}
