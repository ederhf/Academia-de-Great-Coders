using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CalculatesHighestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(90f);
            book.AddGrade(50f);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(90f, stats.HighestGrade);
        }

        [TestMethod]
        public void PassByValue()
        {
            GradeBook book = new GradeBook();
            book.Name = "Não setado";
            SetName(book);

            Assert.AreEqual("Não setado", book.Name);

        }

        private void SetName(GradeBook book)
        {
            book.Name = "Nome Setado";
        }
    }
}
