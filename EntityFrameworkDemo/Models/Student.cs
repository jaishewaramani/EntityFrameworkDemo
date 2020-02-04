using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.Models
{
    public class Student
    {
        [Key]
        public int studentId { get; set; }
        public string studentName { get; set; }
        public string studentCourse { get; set; }
        public int studentFees { get; set; }
    }
}