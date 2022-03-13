namespace ProjectTracker.Core.Common.Models.Domain.Abstract;

public abstract class BaseEntity<TUserId>
    : ICreatableEntity<TUserId>
    , IUpdatableEntity<TUserId>
    , IDeletableEntity<TUserId>
    where TUserId : struct
{
    public DateTime CreatedAt { get; private set; }
    public TUserId CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; private set; }
    public TUserId? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; private set; }
    public TUserId? DeletedBy { get; set; }

    public void SetCreatedAt(DateTime at)
    {
        CreatedAt = at;
    }
    public void SetUpdatedAt(DateTime? at)
    {
        UpdatedAt = at;
    }
    public void SetDeletedAt(DateTime? at)
    {
        DeletedAt = at;
    }
}

public abstract class BaseEntity<TId, TUserId>
    : BaseEntity<TUserId>, IBaseEntity<TId>
    where TId : struct where TUserId : struct
{
    public TId Id { get; private set; }
}
