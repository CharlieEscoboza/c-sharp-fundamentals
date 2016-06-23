using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades = new float[3];
            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void DateTimeReference()
        {
            DateTime date = new DateTime(2016, 6, 22);
            date = date.AddDays(1);

            Assert.AreEqual(23, date.Day);
        }

        [TestMethod]
        public void StringReference()
        {
            string name = " Charlie ";
            name = name.Trim();

            Assert.AreEqual("Charlie", name);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(ref x);

            Assert.AreEqual(47, x);
        }

        private void IncrementNumber(ref int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypePassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookName(ref book2);
            Assert.AreEqual("A GradeBook", book2.Name);
        }

        private void GiveBookName(ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A GradeBook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Charlie";
            string name2 = "Charlie";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);

            Assert.IsTrue(result);
        }


        [TestMethod]
        public void IntVariableHoldaValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;

            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Testing references";

            Assert.AreEqual(g1.Name, g2.Name);
            Assert.AreSame(g1.Name, g2.Name);
        }
    }
}
