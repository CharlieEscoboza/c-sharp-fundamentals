﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public override void WriteGrades(TextWriter destination)
        {
            List<float> grades = getGrades();
            grades.Reverse();

            foreach (float grade in grades)
            {
                destination.WriteLine(grade);
            }
        }

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }

        public override GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            stats.LowestGrade = float.MaxValue;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public List<float> getGrades()
        {
            return grades;
        }

        protected List<float> grades;

    }
}
