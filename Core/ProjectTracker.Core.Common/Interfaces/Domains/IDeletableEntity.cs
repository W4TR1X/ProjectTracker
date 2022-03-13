namespace ProjectTracker.Core.Common.Interfaces.Domains;

public interface IDeletableEntity<TUserId> : IBaseEntity where TUserId : struct
{
    DateTime? DeletedAt { get; }
    TUserId? DeletedBy { get; set; }

    void SetDeletedAt(DateTime? at);
}