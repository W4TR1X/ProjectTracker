namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class ProjectCommentConfiguration : IEntityTypeConfiguration<ProjectComment>
    {
        public void Configure(EntityTypeBuilder<ProjectComment> builder)
        {
            builder.Configure();
            builder.Property(pc => pc.ProjectId).ConfigureGuid();
            builder.Property(pc => pc.UserId).ConfigureUser();
            builder.Property(pc => pc.Comment).IsRequired().HasMaxLength(200);

            //TODO: Task'lerin commentleri gelmemeli
            builder.HasOne(pc => pc.Project)
                .WithMany(p => p.ProjectComments)
                .HasForeignKey(pc => pc.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(pc => pc.ProjectTask)
                .WithMany(pt => pt.ProjectComments)
                .HasForeignKey(pc => pc.TaskId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(pc => pc.ParentComment)
                .WithMany(pc => pc.ProjectComments)
                .HasForeignKey(pc => pc.ParentCommentId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
