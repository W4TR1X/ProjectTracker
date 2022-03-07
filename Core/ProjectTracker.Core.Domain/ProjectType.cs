namespace ProjectTracker.Core.Domain;

public class ProjectType : HasKeyBaseDomainObject
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public bool IsDisabled { get; set; }    

}