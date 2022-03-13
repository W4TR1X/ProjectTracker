namespace ProjectTracker.Core.Domain.Entities;

public class TaskCheckListRow : BaseEntity<Guid, Guid>
{
    public Guid TaskId { get; set; }
    public Guid OwnerUserId { get; set; }    
    public string Description { get; set; }
    public Guid CompletorUserId { get; set; }   

    public virtual TaskUser OwnerUser { get; set; }
    public virtual TaskUser CompleterUser { get; set; }
}
