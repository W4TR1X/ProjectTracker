namespace ProjectTracker.Core.Common.Interfaces.Domains;

public interface IDeletableEntity<TUserId> : IBaseEntity where TUserId : struct
{
    DateTime? DeletedAt { get; set; }
    TUserId? DeletedBy { get; set; }
}