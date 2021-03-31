using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netOnTheWeb.Models;

namespace netOnTheWeb.Models
{
    
    public class Student
    {
        private int id;
        private string name;
        private Class studentClass;

        public Student(int id, string name, Class studentClass)
        {
            this.id = id;
            this.name = name;
            this.studentClass = studentClass;
        } 

        public int getId()
        {
            return this.id;
        }

        public string getName()
        {
            return this.name;
        }

        public Class getStudentClass()
        {
            return this.studentClass;
        }

    }
}
