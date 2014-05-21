using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BLL;
using DAL.Mocking;
using Core.PresenceInfo;
using Core;
using Core.StudentInfo;

namespace Test
{
    class BLL
    {
        [TestFixture]

        private class UnitTestBLL
        {
            private Repository TestRepository { get; set; }
            private Person TestPerson { get; set; }
            private LateTicket TestTicket { get; set; }
            private LateTicket TestTicketIssue { get; set; }
            private Student TestStudent { get; set; }
            private ResponsibleParty TestRelative { get; set; }


            [TestFixtureSetUp]
            public void TestFixtureSetupMethod()
            {
                TestRepository = new Repository();
                TestPerson = new Person("first", "second", "street", "city");
                TestTicket = new LateTicket("testTicketID");
                TestTicketIssue = new LateTicket("testTicketID", 2014, 5, 19, "13", "Jane", "Mart", 08.35);
                TestStudent = new Student("testID");
                TestRelative = new ResponsibleParty("first", "last", "testNumber", "testStreet", "testCity");
            }

            [TestFixtureTearDown]
            public void TestFixtureTearDownMethod()
            {
                TestRepository = null;
                TestStudent = null;
                TestTicket = null;
                TestRelative = null;
            }

            [Test]
            public void TestThereExistsAPerson()
            {
                Assert.NotNull(TestPerson);
            }

            [Test]
            public void TestFullNameHasAFirstAndLast()
            {
                FullName Name = new FullName("testFirst", "testLast");
                Assert.NotNull(Name.First);
                Assert.NotNull(Name.Last);
            }
            
            [Test]
            public void TestPersonHasAName()
            {
                Assert.NotNull(TestPerson.Name);
            }
     
            [Test]
            public void TestPersonHasAPhoneNumber()
            {
                Assert.IsNotNull(TestPerson.ContactNumber);
            }

            [Test]
            public void TestResidentialAddressHasStreetAndCity()
            {
                ResidentialAddress testAddress = new ResidentialAddress("testStreet", "testCity");
                Assert.NotNull(testAddress.Street);
                Assert.NotNull(testAddress.City);
            }
            
            [Test]
            public void TestPersonHasAnAddress()
            {
                Assert.NotNull(TestPerson.HomeAddress);
            }

            /// <summary>
            /// To promote the Liskov Substitution Principle
            /// </summary>
            [Test]
            public void TestEnsureAStudentIsAPerson()
            {
                Assert.IsInstanceOf(TestPerson.GetType(), TestStudent);
            }
            
            [Test]
            public void TestStudentHasAName()
            {
                TestStudent.Name = new FullName("testFirstName", "testLastName");
                Assert.NotNull(TestStudent.Name.First);
                Assert.NotNull(TestStudent.Name.Last);
            }     

            [Test]
            public void TestStudentHasAnID()
            {
                TestStudent.ID = "10";
                Assert.NotNull(TestStudent.ID);
            }

            [Test]
            public void TestStudentIDCannotBeMoreThan3Characters()
            {
                TestStudent.ID = "1232224445545";
                Assert.NotNull(TestStudent.ID);
                Assert.AreEqual("123", TestStudent.ID);
            }

            [Test]
            public void TestEnsureAResponsiblePartyIsAPerson()
            {
                Assert.IsInstanceOf(TestPerson.GetType(), TestRelative);
            }

            [Test]
            public void TestResponsiblePartyHasAName()
            {
                FullName testName = new FullName("first", "last");                
                Assert.AreEqual(testName.First, TestRelative.Name.First);
                Assert.AreEqual(testName.Last, TestRelative.Name.Last);
            }            

            [Test]
            public void TestStudentHasAResponsibleParty()
            {                
                TestStudent.PersonResponsible = TestRelative;
                Assert.NotNull(TestStudent.PersonResponsible);
            }

            [Test]
            public void TestPhoneNumberCanBeMobileAndHome()
            {
                PhoneNumber testNumber = new PhoneNumber("testHome", "testMobile");
                Assert.NotNull(testNumber.Home);
                Assert.NotNull(testNumber.Mobile);
            }

            public void TestPossibleToHaveOnlyOnePhoneNumber()
            {
                PhoneNumber testNumber = new PhoneNumber("testNumber");
                Assert.NotNull(testNumber.ContactNumber);
            }

            [Test]
            public void TestStudentAllowedNotToHaveAContactNumber()
            {
                TestStudent.ContactNumber = new PhoneNumber();
                Assert.Null(TestStudent.ContactNumber.Home);
                Assert.Null(TestStudent.ContactNumber.Mobile);
            }

            [Test]
            public void TestResponsiblePartyMustHaveAContactNumber()
            {                
                PhoneNumber testPhoneNumber = new PhoneNumber();
                testPhoneNumber = TestRelative.ContactNumber;
                Assert.NotNull(testPhoneNumber);
            }

            [Test]
            public void TestResponsiblePartyCanHaveBothHomeAndMobileNumber()
            {
                ResponsibleParty testRelative1 = new ResponsibleParty("first", "last", "testHomeNumber", "testMobileNumber", "testStreet", "testCity");
                PhoneNumber testPhoneNumber = new PhoneNumber();
                testPhoneNumber.Home = testRelative1.ContactNumber.Home;
                testPhoneNumber.Mobile = testRelative1.ContactNumber.Mobile;
                Assert.NotNull(testPhoneNumber.Home);
                Assert.NotNull(testPhoneNumber.Mobile);
            }            

            [Test]
            public void TestResponsiblePartyHasAResidentialAddress()
            {                
                ResidentialAddress testAddress = new ResidentialAddress("testStreet", "testCity");
                testAddress = TestRelative.HomeAddress;
                Assert.NotNull(testAddress);
            }

            [Test]
            public void TestResponsiblePartyHasProperAddressWithStreetAndCity()
            {
                ResidentialAddress testAddress = new ResidentialAddress("testStreet", "testCity");
                testAddress = TestRelative.HomeAddress;
                Assert.NotNull(testAddress.City);
                Assert.NotNull(testAddress.Street);
            }

            [Test]
            public void TestLateTicketExists()
            {
                Assert.NotNull(TestTicket);
            }

            [Test]
            public void TestLateTicketHasAnID()
            {
                Assert.NotNull(TestTicket.ID);                
            }            

            [Test]
            public void TestLateTicketHasStudentInfo()
            {
                TestTicket.StudentInfo = new Student("testID");
                TestTicket.StudentInfo = TestStudent;
                Assert.NotNull(TestTicket.StudentInfo);                
            }

            [Test]
            public void TestLateTicketHasArrivalTime()
            {
                TestTicket.IssueDate = new DateTime(2014, 5, 16);
                Assert.NotNull(TestTicket.IssueDate);
                Assert.AreEqual(16, TestTicket.IssueDate.Day);
                Assert.AreEqual(5, TestTicket.IssueDate.Month);
                Assert.AreEqual(2014, TestTicket.IssueDate.Year);
            }

            [Test]
            public void TestLateTicketWhenIssuedHasAnIssueDateNameAndArrivalTime()
            {
                Assert.NotNull(TestTicketIssue.IssueDate);
                Assert.NotNull(TestTicketIssue.TimeArrived);
                Assert.NotNull(TestTicketIssue.StudentInfo.Name);
            }

            [Test]
            public void TestAssertLatenessDirectoryIsNotNull()
            {
                LateDirectory newDirectory = new LateDirectory("testTickedID");
                Assert.NotNull(newDirectory);
            }

            [Test]
            public void TestCalculateLatenessAmountShouldReturn2()
            {
                LateDirectory newDirectory = new LateDirectory("testTicketID");
                int amount = newDirectory.CalculateLatenessAmountOfParticularStudent("Jane", "Smith");
                Assert.AreEqual(2, amount);
            }

            [Test]
            public void TestRetrieveCorrectDataByTicketID()
            {
                LateDirectory newDirectory = new LateDirectory("testTicketID");
                TestTicket = newDirectory.RetrieveParticularTicketData("3");
                Assert.AreEqual("Rita", TestTicket.StudentInfo.Name.First);
                Assert.AreEqual("Ram", TestTicket.StudentInfo.Name.Last);
                Assert.AreEqual(8.26, TestTicket.TimeArrived);
                Assert.AreEqual(2014, TestTicket.IssueDate.Year);
                Assert.AreEqual(5, TestTicket.IssueDate.Month);
                Assert.AreEqual(2, TestTicket.IssueDate.Day);
            }          
  
            [Test]
            public void TestRetrieveLatenessOnParticularDate()
            {
                LateDirectory testDirectory = new LateDirectory("testTicketID");
                List<LateTicket> LateTicketOfADay = testDirectory.RetrieveParticularDateInfo(2014, 5, 2);
                Assert.AreEqual(3, LateTicketOfADay.Count);
                Assert.AreEqual("1", LateTicketOfADay[0].ID);
                Assert.AreEqual("2", LateTicketOfADay[1].ID);
                Assert.AreEqual("3", LateTicketOfADay[2].ID);
            }

            [Test]
            public void TestRetrieveAllLatenessData()
            {
                LateDirectory testDirectory = new LateDirectory("testTicketID");
                List<LateTicket> AllTickets = testDirectory.GetAllTickets();
                Assert.AreEqual(7, AllTickets.Count);
            }

            [Test]
            public void TestAmountOfLatenessByStudentID()
            {
                LateDirectory newDirectory = new LateDirectory("testTicketID");
                int amount = newDirectory.CalculateLatenessAmountOfParticularStudent("20");
                Assert.AreEqual(2, amount);
            }
        }
    }
}
