using System;
using System.Collections.Generic;
using System.Text;

namespace CronJob
{
    public class JobProcessor
    {
        public JobProcessor()
        {
        
            using (var context = new JobContext())
            {
                var jobDetails = new JobRunDetails
                {
                    JobName = $"SampleJob_{new Random().Next()}",
                    ExecutionTime = DateTime.Now,
                    JobId = Guid.NewGuid().ToString()
                };
                context.JobRunDetails.Add(jobDetails);
                context.SaveChanges();
            }
        }
    }
}
