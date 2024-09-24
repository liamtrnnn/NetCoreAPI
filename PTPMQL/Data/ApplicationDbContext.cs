using Microsoft.EntityFrameworkCore;
using PTPMQL.Models;

namespace PTPMQL.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Student> Student { get ; set;}
       
    }
}