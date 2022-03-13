namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class TaskChecklistConfiguration : IEntityTypeConfiguration<TaskCheckListRow>
    {
        public void Configure(EntityTypeBuilder<TaskCheckListRow> builder)
        {
            builder.Configure();
            builder.Property(tc => tc.TaskId).IsRequired();
            builder.Property(tc => tc.OwnerUserId).IsRequired();
            builder.Property(tc => tc.Description).IsRequired();
            builder.Property(tc => tc.CompletorUserId).IsRequired();

            builder.HasOne(tc => tc.OwnerUser)
                .WithMany(tu => tu.TaskCheckListRows)
                .HasForeignKey(tc => tc.OwnerUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(tc => tc.CompleterUser)
                .WithMany(tu => tu.CompletedTaskCheckListRows)
                .HasForeignKey(tc => tc.CompletorUserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
