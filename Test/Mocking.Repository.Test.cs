using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DAL.Mocking;
using Core.PresenceInfo;

namespace Test
{
	[TestFixture]

    public class Mocking
    {
        private Repository MockRepository { get; set; }

		[TestFixtureSetUp]
        public void TestFixtureSetupMethod()
        {
            MockRepository = new Repository();
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDownMethod()
        {
            MockRepository = null;
        }

		[Test]
		public void MockingDataSource_ShouldReturn7()
        {
            List<LateTicket> testTicket = MockRepository.MockingDataSource();
            Assert.AreEqual(7, testTicket.Count);
        }

		[Test]
		public void WriteToDataSource_ShouldReturn8()
        {
            List<LateTicket> testTicket = MockRepository.WriteToDataSource("15", 2014, 03, 10, "9", "Jacob", "Will", 8.35);
            Assert.AreEqual(8, testTicket.Count);
        }

		[Test]
		public void DeleteData_ShouldReturn6item()
        {
            List<LateTicket> testTicket = MockRepository.DeleteData("5");

            Assert.AreEqual(6, testTicket.Count);
        }

		
    }
}
