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
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Dessert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", job1.Name);
            Assert.AreEqual("ACME", job1.EmployerName.Value);
            Assert.AreEqual("Dessert", job1.EmployerLocation.Value);
            Assert.AreEqual("Quality Control", job1.JobType.Value);
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.value);
        }

    }
}
