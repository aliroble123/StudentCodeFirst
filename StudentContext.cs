using System.Data.Entity;

namespace StudentCodeFirst
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=StudentContext")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
