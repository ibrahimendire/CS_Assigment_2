using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.AreEqual(1, job2.Id - job1.Id);
            Assert.IsTrue(job2.Id -job1.Id != 0);
        }
       [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Dessert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", job4.Name);
            Assert.AreEqual("ACME", job4.EmployerName.Value);
            Assert.AreEqual("Dessert", job4.EmployerLocation.Value);
            Assert.AreEqual("Quality Control", job4.JobType.Value);
            Assert.AreEqual("Persistence", job4.JobCoreCompetency.value);
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job5 = new Job("Programmer", new Employer("ACME"), new Location("USA"), new PositionType("internShip"), new CoreCompetency("JavaScript"));
            Job job6 = new Job("Programmer", new Employer("ACME"), new Location("USA"), new PositionType("internShip"), new CoreCompetency("JavaScript"));
            Assert.IsFalse(job5==job6);
        }
        [TestMethod]
        public void TestJobToString()
        {
            Job job6 = new Job("SoftWare tester", new Employer("ACME"), new Location("USA"), new PositionType("Programmer"), new CoreCompetency("C#"));
            Assert.AreEqual("ID: 6\nName: SoftWare tester\nEmployer: ACME\nLocation: USA\nPosition Type: Programmer\nCore Competency: C#\n", job6.ToString());
        }

    }
}
