using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace EFGetStarted.Models
{

    public enum Grade
    {
        A, B, C, D, F
    }
    class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }  // Correspond to the Navigation property as foreign key
        public int StudentID { get; set; } // Correspond to the Navigation property as foreign key
        public Grade? Grade { get; set; }

        // Navigation Properties
        public Course Course { get; set; }
        public Student Student { get; set; }

    }
}
