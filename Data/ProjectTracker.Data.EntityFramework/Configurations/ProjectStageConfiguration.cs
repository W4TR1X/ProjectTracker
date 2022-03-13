namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class ProjectStageConfiguration : IEntityTypeConfiguration<ProjectStage>
    {
        public void Configure(EntityTypeBuilder<ProjectStage> builder)
        {
            builder.ToTable("ProjectStages");

            builder.Property(ps => ps.ProjectId).ConfigureGuid();

            builder.HasOne(x => x.Stage)
                .WithOne(x => x.ProjectStage)
                .HasForeignKey<ProjectStage>(x => x.Id)
                .HasPrincipalKey<Stage>(x => x.Id)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ps => ps.Project)
                .WithMany(p => p.ProjectStages)
                .HasForeignKey(ps => ps.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
