using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{





    public class FirstDbContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDb;Integrated Security=true; Initial Catalog =FirstKargahDB;");
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Kelas> Kelas { get; set; }




    }







}
