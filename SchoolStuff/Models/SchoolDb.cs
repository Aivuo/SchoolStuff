using DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolStuff.Models
{
    public class SchoolDb : DbContext
    {
            public DbSet<Assignment> Assignments { get; set; }
            public DbSet<Course> Courses { get; set; }
            public DbSet<Student> Students { get; set; }
            public DbSet<Teacher> Teachers { get; set; }
    }
}
