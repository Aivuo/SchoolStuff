﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseClasses
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }
    }
}
}
