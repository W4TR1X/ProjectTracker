namespace ProjectTracker.Core.Domain.Entities;

public class TaskUser : BaseEntity<Guid, Guid>
{
    public Guid TaskId { get; set; }
    public Guid UserId { get; set; }
    public ProjectJoinTypeEnum ProjectJoinTypeEnum { get; set; }

    public virtual ProjectTask ProjectTask { get; set; }
    public virtual User User { get; set; }

}
