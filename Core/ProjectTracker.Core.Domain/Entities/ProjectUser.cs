namespace ProjectTracker.Core.Domain.Entities;

public class ProjectUser : BaseEntity<Guid, Guid>
{
    public Guid ProjectId { get; set; }
    public bool TrackActions { get; set; }
    public Guid UserId { get; set; }
    public ProjectJoinTypeEnum JoinType { get; set; }

    public virtual User User { get; set; }
    public virtual Project Project { get; set; }

    public virtual ICollection<TaskActivity> TaskActivities { get; set; }
    public virtual ICollection<TaskRequest> OwnedTaskRequests { get; set; }
    public virtual ICollection<TaskRequest> TargetTaskRequests { get; set; }

}
