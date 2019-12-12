using BID.SWE.EXAM.Impl;
using NUnit.Framework;

namespace NUnitPruefung
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        private Exercise1 testex1 = new Exercise1();

        [Test]
        public void TestCellPrinter1()
        {
            try
            {
                CellPrinter print = testex1.Method1() as CellPrinter;
                Assert.IsTrue(true);
            }
            catch (System.Exception)
            {
                Assert.IsTrue(false);
            }
        }

        public void TestCellPrinter2()
        {
            CellPrinter print = testex1.Method1() as CellPrinter;
            
        }
    }
}