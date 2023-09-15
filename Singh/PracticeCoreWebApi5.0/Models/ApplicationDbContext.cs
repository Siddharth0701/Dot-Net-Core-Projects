using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCoreWebApi5._0.Models
{
    public class ApplicationDbContext: DbContext
    {

       string connectionString = "Server=SIDDHARTH-SINGH;Database=practice5dotnet; integrated security = SSPI; trustservercertificate=True;MultipleActiveResultSets=true";

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<SignUp> SignUp { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
