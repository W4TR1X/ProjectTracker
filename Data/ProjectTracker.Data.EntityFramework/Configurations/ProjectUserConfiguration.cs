using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class ProjectUserConfiguration : IEntityTypeConfiguration<ProjectUser>
    {
        public void Configure(EntityTypeBuilder<ProjectUser> builder)
        {
            builder.Configure();
            builder.Property(pu => pu.ProjectId).IsRequired();
            builder.Property(pu => pu.UserId).IsRequired();

            builder.HasOne(pu => pu.User)
                .WithMany(u => u.ProjectUsers)
                .HasForeignKey(pu => pu.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(pu => pu.Project)
               .WithMany(p => p.ProjectUsers)
               .HasForeignKey(pu => pu.ProjectId)
               .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
