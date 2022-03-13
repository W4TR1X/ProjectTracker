namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class TaskActivityConfiguration : IEntityTypeConfiguration<TaskActivity>
    {
        public void Configure(EntityTypeBuilder<TaskActivity> builder)
        {
            builder.Configure();
            builder.Property(ta => ta.TaskId).ConfigureGuid();

            builder.Property(ta => ta.StartDate).ConfigureDateTime();
            builder.Property(ta => ta.TotalTime).IsRequired();

            builder.Property(ta => ta.UserId).ConfigureUser();

            builder.Property(ta => ta.Description).IsRequired().HasMaxLength(200);

            builder.HasOne(ta => ta.ProjectTask)
                .WithMany(pt => pt.TaskActivities)
                .HasForeignKey(ta => ta.TaskId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ta => ta.OwnerUser)
              .WithMany(pu => pu.TaskActivities)
              .HasForeignKey(ta => ta.UserId)
              .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
