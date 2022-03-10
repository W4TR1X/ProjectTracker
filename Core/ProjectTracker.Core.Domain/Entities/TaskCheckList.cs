namespace ProjectTracker.Core.Domain.Entities;

public class TaskCheckList : BaseEntity<Guid, Guid>
{
    public Guid TaskId { get; set; }
    public Guid OwnedUserId { get; set; }    
    public string Description { get; set; }
    public Guid CompletorUserId { get; set; }   

    public virtual TaskUser OwnedUser { get; set; }
    public virtual TaskUser CompleterUser { get; set; }
}
