using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netOnTheWeb.Models;

namespace netOnTheWeb.Models
{

    public class ClassesList
    {
        private List<Class> classesList = new List<Class>();
        
        public ClassesList()
        {
            classesList.Add(new Class(11, "Lamarr-11", null));
            classesList.Add(new Class(12, "Lamarr-12", null));
            classesList.Add(new Class(13, "Lamarr-13", null));
        }
       
        

        public void setTeachers(TeachersList teachers)
        {
            Array allTeachers = teachers.getAllTeachers();

            foreach( Teacher teacher in allTeachers)
            {
                var teacherID = teacher.getTeacherId();
                var teacherName = teacher.getTeacherName();
                var teacherClassId = teacher.getClass().getClassId();

                classesList.Find(x => x.getClassId() == teacherClassId).setTeacher(teacher);
            
            }

        }


        public Array getAllClasses()
        {
            return classesList.ToArray();
        }


        public Class getClassFromList(int index)
        {
            return classesList[index];
        }
    
    }

}
