

namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class ProjectAttachmentConfiguration : IEntityTypeConfiguration<ProjectAttachment>
    {
        public void Configure(EntityTypeBuilder<ProjectAttachment> builder)
        {
            builder.Property(pa => pa.ProjectId).IsRequired();
            builder.Property(pa => pa.AttachmentPath).IsRequired();
            builder.Property(pa => pa.DisplayText).HasMaxLength(50);
            builder.Property(pa => pa.Description)
                .IsRequired()
                .HasMaxLength(200);


            builder.HasOne(pa => pa.Project)
                    .WithMany(p => p.ProjectAttachments)
                    .HasForeignKey(pa => pa.ProjectId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(pa => pa.ProjectTask)
                .WithMany(pt => pt.ProjectAttachments)
                .HasForeignKey(pa => pa.TaskId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
