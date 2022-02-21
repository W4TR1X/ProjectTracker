namespace ProjectTracker.Core.Domain;

public abstract class BaseDomainObject
    : ICreatableDomainObject, IUpdatableDomainObject, IDeletableDomainObject
{
    public DateTime CreatedAt { get; set; }
    public Guid CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }
    public Guid? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }
    public Guid? DeletedBy { get; set; }
}

