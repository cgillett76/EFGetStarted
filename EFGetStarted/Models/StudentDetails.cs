using EFGetStarted.Data;
using EFGetStarted.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFGetStarted.Models
{
    class StudentDetails
    {
        public string CourseTitle { get; set; }
        public string Grade { get; set; }


        public static List<StudentDetails> CourseDetails(int id)
        {
            


            using (var _context = new SchoolContext())
            {
                

                // Display the studetns name and details
                var students = _context.Students.Where(s => s.ID == id);
                foreach (var student in students)
                {
                    Console.WriteLine("Lastname: " + student.LastName);
                    Console.WriteLine("Firstname: " + student.FirstMidName);
                    Console.WriteLine("Enrollment Date: {0}", student.EnrollmentDate.ToLongDateString());
                    Console.WriteLine();
                    Console.WriteLine("Course Title\t\tGrade");
                }

                // Display the Course Title and Grade
                var enrollments = _context.Enrollments.Where(s => s.StudentID == id);

                var courses = from c in _context.Courses
                              join e in enrollments
                              on c.CourseID equals e.CourseID
                              select new
                              {
                                  Title = c.Title,
                                  Grade = e.Grade
                              };


                List<StudentDetails> studentDetails = new List<StudentDetails>();

                foreach (var item in courses)
                {
                    studentDetails.Add(new StudentDetails() { CourseTitle = item.Title, Grade = item.Grade.ToString() });
                }

                foreach (var item in studentDetails)
                {
                    Console.WriteLine("{0}\t\t{1}", item.CourseTitle, item.Grade);
                }
                return studentDetails;
            }
        }

        public static void CourseDetailsView(int id)
        {
            Console.Clear();
            DisplayMethods.DisplayHeader("Details of Student");


            using (var _context = new SchoolContext())
            {
                // Display the studetns name and details
                var students = _context.Students.Where(s => s.ID == id);
                foreach (var student in students)
                {
                    Console.WriteLine("Lastname: " + student.LastName);
                    Console.WriteLine("Firstname: " + student.FirstMidName);
                    Console.WriteLine("Enrollment Date: {0}", student.EnrollmentDate.ToLongDateString());
                    Console.WriteLine();
                    Console.WriteLine("Course Title\t\tGrade");
                }

                // Display the Course Title and Grade
                var enrollments = _context.Enrollments.Where(s => s.StudentID == id);

                var courses = from c in _context.Courses
                              join e in enrollments
                              on c.CourseID equals e.CourseID
                              select new
                              {
                                  Title = c.Title,
                                  Grade = e.Grade
                              };

                foreach (var item in courses)
                {
                    Console.WriteLine("{0}\t\t{1}", item.Title, item.Grade);
                }
                Console.WriteLine("Press <Enter> to Return to List");

                _context.Dispose();
            }
            
        }

    }
}
