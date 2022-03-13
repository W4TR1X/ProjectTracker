namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class TaskUserConfiguration : IEntityTypeConfiguration<TaskUser>
    {
        public void Configure(EntityTypeBuilder<TaskUser> builder)
        {
            builder.Configure();

            builder.Property(x => x.TaskId)
                .ConfigureGuid();

            builder.Property(x => x.UserId)
                .ConfigureUser();


            builder.HasOne(x => x.ProjectTask)
                .WithMany(x => x.TaskUsers)
                .HasForeignKey(x => x.TaskId);

            builder.HasOne(x => x.User)
                .WithMany(x => x.TaskUsers)
                .HasForeignKey(x => x.UserId);
        }
    }
}
