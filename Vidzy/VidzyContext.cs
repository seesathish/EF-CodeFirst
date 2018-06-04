using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidzy.EntityConfigurations;

namespace Vidzy
{
    public class VidzyContext: DbContext
    {
        public VidzyContext()
           : base("name=VidzyContext")
        {
        }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VideoConfigurations());
            modelBuilder.Configurations.Add(new GenreConfigurations());
            modelBuilder.Configurations.Add(new TagConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
