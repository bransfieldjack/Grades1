﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades1
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);

            GradeStatistics stats = book.ComputeStatistics();
       

            GradeBook book2 = book;
            book2.AddGrade(75);
        }
    }
}

