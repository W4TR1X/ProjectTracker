namespace ProjectTracker.Core.Domain.Entities;

public class ProjectHistory : BaseEntity<Guid, Guid>
{
    public Guid ProjectId { get; set; }
    public Guid? TaskId { get; set; }
    public Guid OwnerUserId { get; set; }    
    public string Details { get; set; } 

    public virtual Project Project { get; set; }    
    public virtual ProjectTask? ProjectTask { get; set; }
    public virtual User OwnerUser { get; set; }

}
