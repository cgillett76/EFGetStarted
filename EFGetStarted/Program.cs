using EFGetStarted.Data;
using EFGetStarted.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EFGetStarted
{
    class Program
    {
        

        static void Main(string[] args)
        {


            
            using (var _context = new SchoolContext())
            {

                foreach (var student in _context.Students)
                {
                    Console.WriteLine("Lastname: " + student.LastName);
                    Console.WriteLine("Firstname: " + student.FirstMidName);
                    Console.WriteLine("Enrollment Date: {0}", student.EnrollmentDate.ToLongDateString());
                    Console.WriteLine();
                    Console.WriteLine("Course Title\t\tGrade");

                    // Produces a query for the against the Student table and the Enrollment table on ID > StudentID
                    var enrollments = _context.Enrollments.Where(s => s.StudentID == student.ID);

                    
                    // Takes the output from 'enrollments' and does inner join 
                    var courses = from c in _context.Courses
                                  join e in enrollments
                                  on c.CourseID equals e.CourseID
                                  select new
                                  {
                                      CourseTitle = c.Title,
                                      e.Grade
                                  };


                    foreach (var item in courses)
                    {                        
                        Console.WriteLine("{0}\t\t{1}", item.CourseTitle, item.Grade);
                    }

                    Console.WriteLine();
                }

                Console.ReadLine();

                /* WORKING
                foreach (var student in _context.Students)
                {
                    Console.WriteLine("{0}\t{1}", student.ID, student.FirstMidName);
                    Console.WriteLine();

                    var enrollments = _context.Enrollments.Where(s => s.StudentID == student.ID);
                    

                    foreach (var enrollment in enrollments)
                    {
                        Console.WriteLine("{0}\t\t{1}", enrollment.CourseID, enrollment.Grade);
                    }

                }

                Console.ReadLine();
                */
                

            }

        }


    }
}


