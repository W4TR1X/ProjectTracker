namespace ProjectTracker.Core.Common.Interfaces.Domains;

public interface IUpdatableEntity<TUserId> : IBaseEntity where TUserId : struct
{
    DateTime? UpdatedAt { get; set; }
    TUserId? UpdatedBy { get; set; }
}
