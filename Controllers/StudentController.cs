using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcTestApp.Manager;
using MvcTestApp.Models;
using Npgsql;

namespace MvcTestApp.Controllers
{
    public class StudentController: Controller
    {
       string mgs = "";



        public ActionResult SaveStudent()
        {

            StudentManager studentManager=new StudentManager();
            ViewBag.Students = studentManager.GetStudents();
            // ViewBag.departments = GetAllDepartments();
            ViewBag.departments = studentManager.GetDepartments();
            return View();
        }




        [HttpPost]
        public ActionResult SaveStudent(Student student)

        {
            StudentManager studentManager = new StudentManager();
            if (ModelState.IsValid)
            {
                var connString = DBConnection.ConnectionString;
                NpgsqlConnection conn = new NpgsqlConnection(connString);
                conn.Open();
                string stdTable = '"' + "AllStudent" + '"';
                string stdName = '"' + "StudenName" + '"';
                string stdRegName = '"' + "RegNo" + '"';
                string stdEmail = '"' + "Email" + '"';
                string stdDepartmentNamel = '"' + "DepartmentID" + '"';


                string query = "INSERT INTO public." + stdTable + "(" + stdName + ", " + stdRegName + ", " + stdEmail + ", " + stdDepartmentNamel + ")VALUES('" + student.StudenName + "','" + student.RegNo + "', '" + student.Email + "', '" + student.Name + "'); ";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                int reader = cmd.ExecuteNonQuery();
                if (reader > 0)
                {
                    mgs = "Save sucessfully";
                }

                else
                {
                    mgs = "Saved failed";
                }
            }
           
            //ViewBag.departments = GetAllDepartments();
            ViewBag.departments = studentManager.GetDepartments();
            ViewBag.Students = studentManager.GetStudents();
            ViewBag.massage = mgs;
            return View();
        }

        //public List<string> GetAllDepartments()
        //{
        //    return  new List<string>(){"CSE","EEE","Civil"};
        //}
        //public ActionResult Index()

        //{

        //    //ViewBag.student =student();
        //    return View(student());
        //}

        //public List<Student> student()
        //{
        //    return new List<Student>
        //    {
        //        new Student
        //        {
        //            StudenName = "shhshs",
                    
        //            DepartmentID = "cse",
        //            Email = "shshshs",
        //            RegNo = 09876
                        
        //        },
        //        new Student
        //        {
        //        StudenName = "abul",

        //        DepartmentID = "EEE",
        //        Email = "shshshs@@",
        //        RegNo = 76677

        //    }

        //    };

            

        //}
    }
}