namespace ProjectTracker.Core.Domain.Entities;

public class ProjectStage : Stage
{
    public Guid ProjectId { get; set; }

    public virtual Project Project { get; set; }


    public virtual Stage Stage { get; set; }
}
