namespace ProjectTracker.Core.Common.Interfaces.Domains;

public interface IUpdatableEntity<TUserId> : IBaseEntity where TUserId : struct
{
    DateTime? UpdatedAt { get; }
    TUserId? UpdatedBy { get; set; }

    void SetUpdatedAt(DateTime? at);
}
