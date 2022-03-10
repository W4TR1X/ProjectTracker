namespace ProjectTracker.Core.Domain;

public abstract class BaseEntity<TUserId>
    : ICreatableEntity<TUserId>
    , IUpdatableEntity<TUserId>
    , IDeletableEntity<TUserId> 
    where TUserId : struct
{
    public DateTime CreatedAt { get; set; }
    public TUserId CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }
    public TUserId? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }
    public TUserId? DeletedBy { get; set; }
}

public abstract class BaseEntity<TId, TUserId>
    : BaseEntity<TUserId>, IBaseEntity<TId>
    where TId : struct where TUserId : struct
{
    public TId Id { get; set; }
}