﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades1
{
    public class GradeBook
    {

        public GradeBook()  //Class constructor sets initial values. 
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            stats.HighestGrade = 0;

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;    //Divides the sum of grades by the number of grades stored. 
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades ;

        public object Name { get; set; }
    }
}
 
