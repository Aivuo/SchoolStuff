using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolStuff.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }
    }
}