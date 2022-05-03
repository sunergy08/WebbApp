using Microsoft.EntityFrameworkCore;
using WebbApp.Models;

namespace WebbApp.Context
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }


    }
}
