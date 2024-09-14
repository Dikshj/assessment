using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class StudentDbContext : DbContext
    {
       
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        
        public DbSet<Data> My { get; set; }
    }
}
