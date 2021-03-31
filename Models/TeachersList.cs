using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netOnTheWeb.Models;

namespace netOnTheWeb.Models
{
    public class TeachersList
    {
        private List<Teacher> teachersList = new List<Teacher>();

        public TeachersList()
        {
            //Teacher Koen = new Teacher(15, "Koen");
            //Teacher Tim = new Teacher(20, "Tim");
            //Teacher Sicco = new Teacher(25, "Sicco");

            teachersList.Add(new Teacher(15, "Koen", new ClassesList().getClassFromList(0)));
            teachersList.Add(new Teacher(20, "Tim", new ClassesList().getClassFromList(1)));
            teachersList.Add(new Teacher(25, "Sicco", new ClassesList().getClassFromList(2)));
        }

        public Array getAllTeachers()
        {
            return teachersList.ToArray();
        }

        public Teacher getTeacherFromList(int index)
        {
            return teachersList[index];
            
        }

    }
}



