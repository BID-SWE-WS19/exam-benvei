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

        [Test]
        public void TestCellPrinter2()
        {
            CellPrinter print = testex1.Method1() as CellPrinter;

        }

        private Exercise2 testex2 = new Exercise2();

        [Test]
        public void TestIfDoubleWorks()
        {
            Assert.AreEqual(2, this.testex2.Method2());
        }

        [Test]
        public void TestIfTrue()
        {
            Assert.AreEqual(true, this.testex2.Method3(2));
        }

        [Test]
        public void TestIfFalse()
        {
            Assert.AreEqual(false, this.testex2.Method3(3));
        }

        private Exercise3 testex3 = new Exercise3();

        [Test]
        public void TestHeteroArray()
        {
            try
            {
                Bewegung beweg = testex3.Method2() as Bewegung;
                Assert.IsTrue(true);
            }
            catch (System.Exception)
            {
                Assert.IsTrue(false);
            }
        }
    }
        
}