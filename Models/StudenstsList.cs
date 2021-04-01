using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netOnTheWeb.Models;

namespace netOnTheWeb.Models
{
    public class StudenstsList
    {
        private List<Student> studentsList = new List<Student>();

        public StudenstsList()
        {
            studentsList.Add(new Student(1, "Serkan", new ClassesList().getClassFromList(0)));
            studentsList.Add(new Student(2, "Selin", new ClassesList().getClassFromList(1)));
            studentsList.Add(new Student(3, "Esin", new ClassesList().getClassFromList(2)));

        }

        public Array getAllStudents()
        {
            return studentsList.ToArray();
        }


        public Student getStudentFromList(int index)
        {
            return studentsList[index];
        }
    }
}
