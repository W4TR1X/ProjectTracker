using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class StageConfiguration : IEntityTypeConfiguration<Stage>
    {
        public void Configure(EntityTypeBuilder<Stage> builder)
        {
            builder.Configure();
            builder.Property(ps => ps.Name).IsRequired().HasMaxLength(50);
            builder.Property(ps => ps.Description).HasMaxLength(200);

            builder.HasOne(x => x.ProjectStage)
                .WithOne(x => x.Stage)
                .HasForeignKey<Stage>(x => x.Id)
                .HasPrincipalKey<ProjectStage>(x => x.Id)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.TaskStage)
                .WithOne(x => x.Stage)
                .HasForeignKey<Stage>(x => x.Id)
                .HasPrincipalKey<ProjectStage>(x => x.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
