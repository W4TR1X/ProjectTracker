namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class TaskStageConfiguration : IEntityTypeConfiguration<TaskStage>
    {
        public void Configure(EntityTypeBuilder<TaskStage> builder)
        {
            builder.ToTable("TaskStages");

            builder.Property(ts => ts.TaskId).ConfigureGuid();

            builder.HasOne(x => x.Stage)
                .WithOne(x => x.TaskStage)
                .HasForeignKey<TaskStage>(x => x.Id)
                .HasPrincipalKey<Stage>(x => x.Id)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ps => ps.ProjectTask)
                .WithMany(p => p.TaskStages)
                .HasForeignKey(ps => ps.TaskId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
