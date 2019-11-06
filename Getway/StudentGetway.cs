using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcTestApp.Models;
using Npgsql;

namespace MvcTestApp.Getway
{
    public class StudentGetway
    {
        public List<Student> GetStudent()

        {
            var connString = DBConnection.ConnectionString;
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            string query = "select * from public.\"AllStudent\" inner join \"Department\" on \"AllStudent\".\"DepartmentID\"=\"Department\".\"ID\";";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            conn.Open();
            NpgsqlDataReader reader=cmd.ExecuteReader();

            List<Student> Students=new List<Student>();
            while (reader.Read())
            {
                Student student = new Student();
                student.StudenName = reader["StudenName"].ToString();
                student.Email = reader["Email"].ToString();
                student.RegNo = Convert.ToInt32(reader["RegNo"]);
                student.Name= reader["Name"].ToString();
                Students.Add(student);
            }
            conn.Close();
            return Students;
        }

        public List<Department> GetDepartments()
        {
            List<Department> departments=new List<Department>();
            var connString = DBConnection.ConnectionString;
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            string query = "SELECT \"ID\", \"Name\"\r\n\tFROM public.\"Department\";";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            conn.Open();
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Department department=new Department();
                department.ID = Convert.ToInt32(reader["ID"]); ;
                department.Name = reader["Name"].ToString();
                departments.Add(department);

            }
            conn.Close();
            return departments;
        }
    }
}
