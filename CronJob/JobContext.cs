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

            //optionsBuilder.UseSqlServer(@"Data Source=172.31.25.30,1433;Initial Catalog=CCDP;User id=sa;Password=Pass@w0rd1;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            optionsBuilder.UseSqlServer(@"Data Source=18.140.56.99,1433;Initial Catalog=CCDP;User id=sa;Password=Pass@w0rd1;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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
