using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

  
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
                 
        }
       

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
        public override string ToString()
        {
            string dataNotAvlb = "Data not available";
            string toString = "";
            if ((Name == null || Name.Trim() == "") && (EmployerName == null || EmployerName.ToString().Trim() == "") && (EmployerLocation == null || EmployerLocation.ToString().Trim() == "") &&
                (JobType == null || JobType.ToString().Trim() == "") && (JobCoreCompetency == null || JobCoreCompetency.ToString().Trim() == ""))
            {
                return "OOPS! This job does not seem to exist.";
            }

            toString += "ID: " + Id + "\n";
            if (Name == null || Name.Trim() == "")
            {
                toString += "Name: " + dataNotAvlb + "\n";
            }
            else
            {
                toString += "Name: " + Name + "\n";
            }



            if (EmployerName == null || EmployerName.ToString().Trim() == "")
            {
                toString += "Employer: " + dataNotAvlb + "\n";
            }
            else
            {
                toString += "Employer: " + EmployerName.ToString().Trim() + "\n";
            }


            if (EmployerLocation == null || EmployerLocation.ToString().Trim() == "")
            {
                toString += "Location: " + dataNotAvlb + "\n";
            }
            else
            {
                toString += "Location: " + EmployerLocation.ToString().Trim() + "\n";
            }


            if (JobType == null || JobType.ToString().Trim() == "")
            {
                toString += "Position Type: " + dataNotAvlb + "\n";
            }
            else
            {
                toString += "Position Type: " + JobType.ToString() + "\n";
            }


            if (JobCoreCompetency == null || JobCoreCompetency.ToString().Trim() == "")
            {
                toString += "Core Competency: " + dataNotAvlb;
            }
            else
            {
                toString += "Core Competency: " + JobCoreCompetency.ToString() + "\n";
            }

            return toString;
        }
    }
}
