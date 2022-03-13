namespace ProjectTracker.Core.Common.Interfaces.Domains;

public interface ICreatableEntity<TUserId> : IBaseEntity where TUserId : struct
{
    DateTime CreatedAt { get; }
    TUserId CreatedBy { get; set; }

    void SetCreatedAt(DateTime at);
}
