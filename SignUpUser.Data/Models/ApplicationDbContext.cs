using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignUpUser.Data.Models
{
     public class ApplicationDbContext:DbContext
    {
        string connectionString = "Server=SIDDHARTH-SINGH;Database=signupformWeb; integrated security=SSPI;trustservercertificate=True;MultipleActiveResultSets=true";

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<SignUpWebForm> SignUpWebForm { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
