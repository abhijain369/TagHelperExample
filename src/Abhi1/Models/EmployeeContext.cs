using Microsoft.Data.Entity;

namespace Abhi1.Models
{

    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            builder.UseSqlServer(@"Server=(localdb)\v11.0;Database=EmployeeAbhi1;Trusted_Connection=True;");
        }
    }

   
}
