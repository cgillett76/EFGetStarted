using ConsoleTables;
using EFGetStarted.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFGetStarted.Models
{
    class StudentList
    {
        public IList<Student> Students { get; set; }

        public static void ListStudents()
        {
            using (var _context = new SchoolContext())
            {

                var table = new ConsoleTable("ID", "Last Name", "Firstname", "Enrollment Date");

                foreach (var item in _context.Students)
                {
                    table.AddRow(item.ID, item.LastName, item.FirstMidName, item.EnrollmentDate.ToShortDateString());
                    
                    //Console.WriteLine("{0}\t{1}\t\t{2}\t\t\t{3}\t\t", item.ID, item.LastName, item.FirstMidName, item.EnrollmentDate.ToShortDateString());
                }

                table.Write();
                Console.WriteLine();



                
            }
        }
    }
}
