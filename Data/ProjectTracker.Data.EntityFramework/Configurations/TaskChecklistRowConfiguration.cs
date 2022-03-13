namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class TaskChecklistRowConfiguration : IEntityTypeConfiguration<TaskCheckListRow>
    {
        public void Configure(EntityTypeBuilder<TaskCheckListRow> builder)
        {
            builder.Configure();
            builder.Property(tc => tc.TaskId).ConfigureGuid();
            builder.Property(tc => tc.OwnerUserId).ConfigureUser();
            builder.Property(tc => tc.CompletorUserId).ConfigureUser();

            //TODO: Hani bunun lenghti !!!
            builder.Property(tc => tc.Description).IsRequired();

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
