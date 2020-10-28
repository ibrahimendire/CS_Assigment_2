﻿using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));


            Job jobNameLess = new Job("", new Employer(""), new Location("ኢትዮጵያ"), new PositionType("መሀንድስ"), new CoreCompetency("ግንባታ"));
            Job jobAllEmpty = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            List<Job> jobs = new List<Job>();

            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);

            //add empty name and written in Amharic
            jobs.Add(jobNameLess);
            //Add job all field empty
            jobs.Add(jobAllEmpty);

            foreach (Job job in jobs)
            {
                Console.WriteLine(job);
            }
            
        }
    }
}
