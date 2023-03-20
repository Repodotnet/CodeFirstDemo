using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo.Models
{
    public class EnrollDbContext:DbContext
    {
        public EnrollDbContext(DbContextOptions<EnrollDbContext> options):base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}
