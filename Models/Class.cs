using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netOnTheWeb.Models;

namespace netOnTheWeb.Models
{
    public class Class
    {
        private int id;
        private string name;
        private Teacher teacher;

        public Class(int id, string name, Teacher teacher)
        {
            this.id = id;
            this.name = name;
            this.teacher = teacher;
        }

        public int getClassId()
        {
            return this.id;
        }

        public string getClassName()
        {
            return this.name;
        }

        public Teacher getTeacher()
        {
            return this.teacher;
        }

        public Teacher setTeacher(Teacher teacher)
        {
            this.teacher = teacher;
            return teacher;
        }
    }
}
