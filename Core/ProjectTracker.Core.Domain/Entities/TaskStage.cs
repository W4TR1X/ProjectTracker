namespace ProjectTracker.Core.Domain.Entities;

public class TaskStage : Stage
{
    public Guid TaskId { get; set; }
    public virtual ProjectTask ProjectTask { get; set; }


    public virtual Stage Stage { get; set; }
}
