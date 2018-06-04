using System.Data.Entity;

namespace FluentAPI
{
    public class plutoContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Tag> Tag { get; set; }

        public plutoContext()
            :base("name=DefaultConnection")
        {

        }
    }
}
