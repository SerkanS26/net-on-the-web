using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netOnTheWeb.Models;

namespace netOnTheWeb.Models
{

    public class Teacher
    {
        private int id;
        private string name;
        private Class cLass;


        public Teacher(int id, string name, Class cLass)
        {
            this.id = id;
            this.name = name;
            this.cLass = cLass;
        }


        public int getTeacherId()
        {
            return this.id;
        }

        public string getTeacherName()
        {
            return this.name;
        }

        public Class getClass()
        {
            return this.cLass;
        }
    }
}
