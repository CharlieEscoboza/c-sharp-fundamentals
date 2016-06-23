using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
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

            g1.name = "Testing references";

            Assert.AreEqual(g1.name, g2.name);
            Assert.AreSame(g1.name, g2.name);
        }
    }
}
