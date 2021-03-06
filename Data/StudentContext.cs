using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Student> Students { get; set; }
    }
}