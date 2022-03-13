namespace ProjectTracker.Data.EntityFramework.Configurations
{
    internal class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Configure();
        }
    }
}
