namespace ProjectTracker.Core.Domain.Entities;

public class Project : BaseEntity<Guid, Guid>
{
    public Guid OwnerUserId { get; set; }
    public virtual User OwnerUser { get; set; }

    public Guid? SponsorUserId { get; set; }
    public virtual User? SponsorUser { get; set; }

    public Guid CompanyId { get; set; }
    public virtual Company Company { get; set; }

    public Guid ProjectTypeId { get; set; }
    public virtual ProjectType ProjectType { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }

    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? TargetEndDate { get; set; }
    public int? TargetDayCount { get; set; }

    public ProjectStatusEnum Status { get; set; }
    public ProjectPiorityEnum Piority { get; set; }

    public bool IsPublic { get; set; }
    public bool IsLocked { get; set; }
    public bool IsArchived { get; set; }
}