using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcTestApp.Models;
using Npgsql;

namespace MvcTestApp.Controllers
{
    public class StudentController: Controller
    {
        public string SaveStudent(Student student)

        {
             var connString = DBConnection.ConnectionString;
             NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            string stdTable ='"'+ "AllStudent"+'"';
            string stdName = '"' + "StudenName" + '"';
            string stdRegName = '"' + "RegNo" + '"';
            string stdEmail = '"' + "Email" + '"';
            string stdDepartmentNamel = '"' + "DepartmentName" + '"';


            string query = "INSERT INTO public."+stdTable+"("+ stdName + ", " + stdRegName + ", " + stdEmail + ", " + stdDepartmentNamel +")VALUES('"+student.StudenName+"','"+student.RegNo+"', '"+student.Email+"', '"+student.DepartmentName+"'); ";
        NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            int reader = cmd.ExecuteNonQuery();
            if (reader > 0)
            {
                return "Save sucessfully";
            }
          

            return "Saved failed" ;
        }
      
    }
}