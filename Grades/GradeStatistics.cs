using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public float AverageGrade { get; set; }
        public float HighestGrade { get; set; }
        public float LowestGrade { get; set; }

        public string Description
        {
            get
            {
                string description;

                switch (LetterGrade)
                {
                    case "F":
                        description = "Fail";
                        break;
                    default:
                        description = "Pass";
                        break;
                }

                return description;
            }
        }

        public string LetterGrade
        {
            get
            {
                string result;
               
                if (AverageGrade >= 90)
                {
                    return result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    return result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    return result = "C";
                }
                else if (AverageGrade >= 60)
                {
                    return result = "D";
                }
                else
                {
                    return result = "F";
                }
            }
        }
    }
}
