namespace ProjectTracker.Core.Common.Interfaces.Domains;

public interface ICreatableEntity<TUserId> : IBaseEntity where TUserId : struct
{
    DateTime CreatedAt { get; set; }
    TUserId CreatedBy { get; set; }
}
