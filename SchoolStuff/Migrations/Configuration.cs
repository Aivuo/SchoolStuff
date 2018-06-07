namespace SchoolStuff.Migrations
{
    using DatabaseClasses;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolStuff.Models.SchoolDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolStuff.Models.SchoolDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Course c = new Course { CourseName = ".Net Basics", CourseSubject = SubjectType.Net };
            List<Course> cl = new List<Course> { c };

            context.Courses.AddOrUpdate(c);

            context.Assignments.AddOrUpdate(new Assignment { AssignmentBody = "Something about .Net", Course = c, AssignmentSubject = SubjectType.Net });

            context.Teachers.AddOrUpdate(new Teacher { FirstName = "Fredrik", LastName = "Gullbrandsson", Courses = cl });

            context.Students.AddOrUpdate(new Student { FirstName = "Linus", LastName = "Elofsson", Courses = cl });
        }
    }
}
