using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcTestApp.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please Provide your Name")]
        [Display(Name="Student Name")]
        public string StudenName { get; set; }
        public int RegNo { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
