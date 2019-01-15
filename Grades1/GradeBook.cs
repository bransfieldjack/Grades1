using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades1
{
    class GradeBook
    {

        public GradeBook()  //Class constructor sets initial values. 
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            return new GradeStatistics();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades ;

    }
}

