using System;
namespace OOP
{
    public enum Grade
    {
        A,
        B,
        C,
        D,
        E,
        F
    }

    public class CourseEnrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public Grade Grade { get; set; } 
    }
}

