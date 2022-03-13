namespace ProjectTracker.Core.Domain.Entities;

public class User : BaseEntity<Guid, Guid>
{
    public virtual ICollection<Project> Projects { get; set; }
    public virtual ICollection<Project> SponsoredProjects { get; set; }

    public virtual ICollection<ProjectHistory> ProjectHistories { get; set; }
    public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
    public virtual ICollection<ProjectUser> ProjectUsers { get; set; }

    public virtual ICollection<TaskUser> TaskUsers { get; set; }
}