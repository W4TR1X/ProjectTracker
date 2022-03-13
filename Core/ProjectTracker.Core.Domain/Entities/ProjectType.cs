namespace ProjectTracker.Core.Domain.Entities;

public class ProjectType : BaseEntity<Guid, Guid>
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public bool IsDisabled { get; set; }

    public virtual ICollection<Project> Projects { get; set; }
}