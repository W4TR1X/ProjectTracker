using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class ProjectTaskConfiguration : IEntityTypeConfiguration<ProjectTask>
    {
        public void Configure(EntityTypeBuilder<ProjectTask> builder)
        {
            builder.Configure();
            builder.Property(pt => pt.ProjectId).ConfigureGuid();
            builder.Property(pt => pt.StageId).ConfigureGuid();
            builder.Property(pt => pt.StageId).ConfigureGuid();
            builder.Property(pt => pt.Description).HasMaxLength(200);

            builder.HasOne(pt=>pt.Project)
                .WithMany(p=>p.ProjectTasks)
                .HasForeignKey(pt=>pt.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);

            // TODO: Test this
            builder.HasOne(pt => pt.OwnerTaskStage)
               .WithMany(ts => ts.ProjectTasks)
               .HasForeignKey(x => x.StageId) // <ProjectTask>
                                              //.HasPrincipalKey<TaskStage>(x => x.ProjectTask.Id)
               .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(pt => pt.ParentTask)
               .WithMany(pt => pt.ProjectTasks)
               .HasForeignKey(pt => pt.ParentTaskId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(pt => pt.OwnerUser)
               .WithMany(u => u.ProjectTasks)
               .HasForeignKey(pt => pt.OwnerUserId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.TaskStages)
                .WithOne(x => x.ProjectTask)
                .HasForeignKey(x => x.Id)
                .HasPrincipalKey(x => x.ParentTaskId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
