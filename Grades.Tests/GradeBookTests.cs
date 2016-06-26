using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHieghstGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(50, result.AverageGrade);
        }

        [TestMethod]
        public void LetterGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(100);
            book.AddGrade(100);

            GradeStatistics grades = book.ComputeStatistics();
            Assert.AreEqual("A", grades.LetterGrade);
        }

        [TestMethod]
        public void Description()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(50);
            book.AddGrade(50);

            GradeStatistics grades = book.ComputeStatistics();
            Assert.AreEqual("Fail", grades.Description);
        }
    }
}
