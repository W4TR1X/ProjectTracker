namespace ProjectTracker.Core.Common.Interfaces.Domains;

public interface IHasKeyDomainObject : IDomainObject
{
    Guid Id { get; set; }
}
