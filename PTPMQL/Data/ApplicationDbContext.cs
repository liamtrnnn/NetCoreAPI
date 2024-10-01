using Microsoft.EntityFrameworkCore;
using PTPMQL.Models;

namespace PTPMQL.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Student> Student { get ; set;}
        public DbSet<Person> Person { get; set; }
        public DbSet<Employee> Employee { get; set; }
        
       
    }
}