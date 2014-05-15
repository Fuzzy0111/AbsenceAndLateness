using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BLL;

namespace Test
{
    class BLL
    {
        [TestFixture]

        public class UnitTestBLL
        {
            private LateDirectory NewDirectory { get; set; }

            [TestFixtureSetUp]
            public void TestFixtureSetupMethod()
            {
                NewDirectory = new LateDirectory();
            }

            [TestFixtureTearDown]
            public void TestFixtureTearDownMethod()
            {
                NewDirectory = null;
            }

            [Test]
            public void TestCalculateLatenessAmount_1of4_ShouldReturn1()
            {
                NewDirectory.LateStudent.StudentInfo.ID = "1400";
                int amount = NewDirectory.CalculateLatenessAmount(NewDirectory.LateStudent.StudentInfo.ID);
                Assert.AreEqual(1, amount);
            }
        }
    }
}
