using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class TaskActivityCommentConfiguration : IEntityTypeConfiguration<TaskActivityComment>
    {
        public void Configure(EntityTypeBuilder<TaskActivityComment> builder)
        {
            builder.Configure();
            builder.Property(tac => tac.ActivityId).ConfigureGuid();

            builder.Property(tac => tac.UserId).ConfigureUser();

            builder.Property(tac => tac.Comment).IsRequired().HasMaxLength(200);

            builder.HasOne(tac => tac.TaskActivity)
                .WithMany(ta => ta.TaskActivityComments)
                .HasForeignKey(tac => tac.ActivityId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(tac => tac.ProjectComment)
                .WithMany(pc => pc.TaskActivityComments)
                .HasForeignKey(tac => tac.ProjectCommentId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(tac => tac.TaskUser)
                .WithMany(tu => tu.TaskActivityComments)
                .HasForeignKey(tac => tac.UserId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
