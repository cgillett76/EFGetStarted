using EFGetStarted.Data;
using EFGetStarted.Models;
using EFGetStarted.Methods;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFGetStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDetails.CourseDetailsView(2);

            Console.ReadLine();
        }
    }
}


