namespace ProjectTracker.Core.Common.Interfaces.Domains;

public interface ICreatableDomainObject
{
    DateTime CreatedAt { get; set; }
    Guid CreatedBy { get; set; }
}
