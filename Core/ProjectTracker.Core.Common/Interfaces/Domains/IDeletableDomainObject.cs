namespace ProjectTracker.Core.Common.Interfaces.Domains;

public interface IDeletableDomainObject
{
    DateTime? DeletedAt { get; set; }
    Guid? DeletedBy { get; set; }
}