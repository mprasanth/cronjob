using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CronJob
{
    public class JobContext : DbContext
    {
        public DbSet<JobRunDetails> JobRunDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            
        }
    }

    public class JobRunDetails
    {

        public string JobName { get; set; }
        public int Id { get; set; }
        public string JobId { get; set; }
        public DateTime ExecutionTime { get; set; }
        public DateTime Duration { get; set; }
    }
}
