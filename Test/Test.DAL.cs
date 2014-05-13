using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Data;
using DAL.Helper;
using Core.PresenceInfo;
using DAL;

namespace Test
{
    class Test
    {
        [TestFixture]
        public class UnitTest
        {
            private IReadAFileRepository XMLFile1 { get; set; }
            private IReadAFileRepository FaultyFile1 { get; set; } 

            [TestFixtureSetUp]
            public void TestFixtureSetupMethod()
            {
                XMLFile1 = new ReadAFileRepository(@"c:\LatecomerDocument.XML");
            }

            [TestFixtureTearDown]
            public void TestFixtureTearDownMethod()
            {
                XMLFile1 = null;
            }

            [Test]
            public void TestReadFileXML_1of4_ShouldReturn4Latecomer()
            {
                List<Absent> myList = XMLFile1.ReadXMLFile();
                Assert.AreEqual(4, myList.Count);
            }

        }
    }
}
