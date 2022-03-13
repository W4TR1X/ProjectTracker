using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class TaskRequestConfiguration : IEntityTypeConfiguration<TaskRequest>
    {
        public void Configure(EntityTypeBuilder<TaskRequest> builder)
        {
            builder.Configure();
            builder.Property(tr => tr.TaskId).IsRequired();
            builder.Property(tr => tr.OwnerUserId).IsRequired();
            builder.Property(tr => tr.TargetUserId).IsRequired();

            builder.HasOne(tr => tr.ProjectTask)
                .WithMany(pt => pt.TaskRequests)
                .HasForeignKey(tr => tr.TaskId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(tr => tr.OwnerUser)
                .WithMany(pu => pu.OwnedTaskRequests)
                .HasForeignKey(tr => tr.OwnerUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(tr => tr.TargetUser)
                .WithMany(pu => pu.TargetTaskRequests)
                .HasForeignKey(tr => tr.TargetUserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
