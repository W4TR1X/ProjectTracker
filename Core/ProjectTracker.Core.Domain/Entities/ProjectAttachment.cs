namespace ProjectTracker.Core.Domain.Entities;

public class ProjectAttachment : BaseEntity<Guid, Guid>
{
    public Guid ProjectId { get; set; }
    public virtual Project Project { get; set; }

    public Guid? TaskId { get; set; }
    public virtual ProjectTask? ProjectTask { get; set; }

    public string AttachmentPath { get; set; }
    public string? DisplayText { get; set; }
    public string Description { get; set; }




}
