using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.NameChanged += new NameChangedDelegate(OnNameChange);
            book.NameChanged += new NameChangedDelegate(OnNameChange2);
            book.Name = "A Charlie's Grade book";
            book.Name = "A Grade's book";
            book.AddGrade(95);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }

        static void OnNameChange(string existingString, string newString)
        {
            Console.WriteLine($"Grade book changing name from {existingString} to {newString}");
        }

        static void OnNameChange2(string existingString, string newString)
        {
            Console.WriteLine("***");
        }
    }
}
