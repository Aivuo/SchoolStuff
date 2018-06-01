using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolStuff.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseSubject { get; set; }
        public string CourseName { get; set; }
        public List<Teacher> CourseTeachers { get; set; }
        public List<Student> CourseStudents { get; set; }

        [Required]
        public List<Assignment> CourseAssignments { get; set; }
    }
}