using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolStuff.Models
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}