using System.Reflection;

namespace ProjectTracker.Data.EntityFramework;

public class AppDbContext : DbContext
{  
    #region DbSets
    public DbSet<Company> Companies { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<ProjectAttachment> ProjectAttachments { get; set; }
    public DbSet<ProjectComment> ProjectComments { get; set; }
    public DbSet<ProjectHistory> ProjectHistories { get; set; }

    public DbSet<Stage> Stages { get; set; }
    public DbSet<ProjectStage> ProjectStages { get; set; }
    public DbSet<TaskStage> TaskStages { get; set; }

    public DbSet<ProjectTask> ProjectTasks { get; set; }
    public DbSet<ProjectType> ProjectTypes { get; set; }
    public DbSet<ProjectUser> ProjectUsers { get; set; }
    public DbSet<TaskActivity> TaskActivities { get; set; }
    public DbSet<TaskActivityComment> TaskActivityComments { get; set; }
    public DbSet<TaskCheckListRow> TaskCheckListRows { get; set; }
    public DbSet<TaskRequest> TaskRequests { get; set; }
    public DbSet<TaskUser> TaskUsers { get; set; }
    public DbSet<User> Users { get; set; }
    #endregion

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        // Hello World!
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //configurations altındaki bütün configurationların yapılması için
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}
