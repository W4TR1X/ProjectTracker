using ProjectTracker.Core.Common.Interfaces.Domains;

namespace ProjectTracker.Core.Domain;

public abstract class HasKeyBaseDomainObject
    : BaseDomainObject, IHasKeyDomainObject
{
    public Guid Id { get; set; }
}

