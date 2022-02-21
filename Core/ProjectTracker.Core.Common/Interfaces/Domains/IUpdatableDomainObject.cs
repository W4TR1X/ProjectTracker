namespace ProjectTracker.Core.Common.Interfaces.Domains;

public interface IUpdatableDomainObject
{
    DateTime? UpdatedAt { get; set; }
    Guid? UpdatedBy { get; set; }
}
