namespace ProjectTracker.Core.Domain.Entities;

public class Company : BaseEntity<Guid, Guid>
{
    public virtual ICollection<Project> Projects { get; set; }
}
