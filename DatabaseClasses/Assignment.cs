using System;

namespace DatabaseClasses
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public SubjectType AssignmentSubject { get; set; }
        public string AssignmentBody { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
