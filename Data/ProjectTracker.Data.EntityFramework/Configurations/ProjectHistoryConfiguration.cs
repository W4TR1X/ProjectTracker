namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class ProjectHistoryConfiguration : IEntityTypeConfiguration<ProjectHistory>
    {
        public void Configure(EntityTypeBuilder<ProjectHistory> builder)
        {
            builder.Configure();
            builder.Property(ph => ph.ProjectId).ConfigureGuid();
            builder.Property(ph => ph.OwnerUserId).ConfigureUser();

            //TODO: hasmaxlength belirt
            builder.Property(ph => ph.Details).IsRequired();
  
            builder.HasOne(ph=>ph.Project)
                .WithMany(p=>p.ProjectHistories)
                .HasForeignKey(ph=>ph.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(ph => ph.ProjectTask)
                .WithMany(pt => pt.ProjectHistories)
                .HasForeignKey(ph => ph.TaskId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(ph => ph.OwnerUser)
                .WithMany(u => u.ProjectHistories)
                .HasForeignKey(ph => ph.OwnerUserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
