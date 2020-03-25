using EFGetStarted.Data;
using EFGetStarted.Models;
using EFGetStarted.Methods;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ConsoleTables;

namespace EFGetStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string headerText = "Student List";

            DisplayMethods.DisplayHeader(headerText);

            StudentList.ListStudents();

            Console.Write("Select ID to view details: ");

            string choice = Console.ReadLine();
            int choiceInt = 0;
            Int32.TryParse(choice, out choiceInt);

            StudentDetails.CourseDetailsView(choiceInt);


            Console.ReadLine();
        }
    }
}


