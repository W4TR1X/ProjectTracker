namespace ProjectTracker.Core.Domain.Entities;

public class TaskActivity : BaseEntity<Guid, Guid>
{
    public Guid TaskId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public TimeSpan TotalTime { get; set; }
    public Guid UserId { get; set; }
    public string Description { get; set; }

    public virtual ProjectTask ProjectTask { get; set; }
    public virtual ProjectUser OwnerUser { get; set; }
    public virtual ICollection<TaskActivityComment> TaskActivityComments { get; set; }
}
