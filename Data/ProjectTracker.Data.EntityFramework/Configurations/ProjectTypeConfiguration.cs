using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class ProjectTypeConfiguration : IEntityTypeConfiguration<ProjectType>
    {
        public void Configure(EntityTypeBuilder<ProjectType> builder)
        {
            builder.Configure();
            builder.Property(pt => pt.Name).IsRequired().HasMaxLength(50);
            builder.Property(pt => pt.Description).HasMaxLength(200);

        }
    }
}
