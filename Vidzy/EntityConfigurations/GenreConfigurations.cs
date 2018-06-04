using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy.EntityConfigurations
{
    public class GenreConfigurations: EntityTypeConfiguration<Genre>
    {
        public GenreConfigurations()
        {
            Property(v => v.Name)
               .IsRequired()
               .HasMaxLength(255);
        }
    }
}
