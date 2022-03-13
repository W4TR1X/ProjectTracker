namespace ProjectTracker.Core.Domain.Entities;

public class Stage : BaseEntity<Guid, Guid>
{
    public string Name { get; set; }
    public bool IsSelectable { get; set; }
    public string? Description { get; set; }


    public virtual ProjectStage? ProjectStage { get; set; }
    public virtual TaskStage? TaskStage { get; set; }
    public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
}