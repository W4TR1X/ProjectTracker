namespace ProjectTracker.Core.Common.Interfaces.Domains;

public interface IBaseEntity
{

}

public interface IBaseEntity<TId> : IBaseEntity where TId : struct
{
    TId Id { get; set; }
}