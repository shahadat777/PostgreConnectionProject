using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcTestApp.Getway;
using MvcTestApp.Models;

namespace MvcTestApp.Manager
{
    public class StudentManager
    {
        StudentGetway studentGetway=new StudentGetway();

        public List<Student> GetStudents()
        {
            return studentGetway.GetStudent();
        }

        public List<Department> GetDepartments()
        {
            return studentGetway.GetDepartments();
        }
    }
}
