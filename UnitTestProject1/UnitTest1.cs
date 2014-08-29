using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Person _p;

        [TestInitialize]
        public void BeginTest()
        {
            _p = new Person("Magne");
        }

        [TestMethod]
        public void TestAdult()
        {
            // Under 18 should return false
            _p.Age = 17.99;
            bool result = _p.IsAdult();
            Assert.IsFalse(result);

            // Equal to 18 should return true
            _p.Age = 18.00;
            result = _p.IsAdult();
            Assert.IsTrue(result);

            // Over 18 should return true
            _p.Age = 18.01;
            result = _p.IsAdult();
            Assert.IsTrue(result);
        }

        [TestMethod]

        public void TestEquality()
        {
            var p = new Person {Name = "Børge", Age = 24};
            var otherP = new Person {Name = "Børge", Age = 24};

            Assert.AreEqual(p,otherP);
        }

        [TestMethod]

        public void TestNotEquality()
        {
            var p = new Person { Name = "Børge", Age = 24 };
            var otherP = new Person { Name = "Jens", Age = 24 };

            Assert.AreNotEqual(p, otherP);
        }

        [TestMethod]

        public void TestAgeException()
        {
            var newP = new Person { Name = "Børge", Age = 24 };

            try
            {
                newP.Age = -24;
                Assert.Fail();
            }
            catch (AgeException ae)
            {
                Assert.AreEqual("Alder for lav", ae.Message);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
