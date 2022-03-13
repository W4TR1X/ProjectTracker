namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Configure();

            builder.Property(p => p.OwnerUserId)
                .ConfigureUser();

            builder.Property(p => p.CompanyId)
                .ConfigureGuid();

            builder.Property(p => p.ProjectTypeId)
                .ConfigureGuid();

            builder.Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasMaxLength(200);


            builder.Property(p => p.StartDate)
                .ConfigureDateTime();

            builder.Property(p => p.EndDate)
                .ConfigureDateTime();

            builder.Property(p => p.TargetEndDate)
                .ConfigureDateTime();



        builder.HasOne(p => p.OwnerUser)
                .WithMany(u => u.Projects)
                .HasForeignKey(p => p.OwnerUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.SponsorUser)
                .WithMany(u => u.SponsoredProjects)
                .HasForeignKey(p => p.SponsorUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Company)
                .WithMany(c => c.Projects)
                .HasForeignKey(p => p.CompanyId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(p => p.ProjectType)
                .WithMany(pt => pt.Projects)
                .HasForeignKey(p => p.ProjectTypeId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
