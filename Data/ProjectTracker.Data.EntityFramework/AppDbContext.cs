namespace ProjectTracker.Data.EntityFramework;

public class AppDbContext : DbContext
{
    #region DbSets
    public DbSet<Company> Companies { get; set; }
    #endregion
}
