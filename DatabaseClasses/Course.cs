using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseClasses
{
    public class Course
    {
        public int CourseId { get; set; }
        public SubjectType CourseSubject { get; set; }
        public string CourseName { get; set; }
        public List<Teacher> CourseTeachers { get; set; }
        public List<Student> CourseStudents { get; set; }
        public List<Assignment> CourseAssignments { get; set; }
    }
}
